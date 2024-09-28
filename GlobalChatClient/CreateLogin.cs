using System;
using System.Windows.Forms;
using System.Text.Json;
using SocketIOClient;

namespace GlobalChatClient
{
    public partial class CreateLogin : Form
    {
        public CreateLogin()
        {
            InitializeComponent();
            InitializeSocket();
        }

        private void InitializeSocket()
        {
            var socket = SocketManager.Instance.Socket;
            socket.On("room created", response =>
            {
                this.Invoke((MethodInvoker)async delegate
                {
                    try
                    {
                        string createdRoomName;
                        string creatorName;

                        // Explicitly get the response as JsonElement
                        var jsonElement = response.GetValue<JsonElement>();

                        Console.WriteLine($"Raw response: {jsonElement}");

                        if (jsonElement.ValueKind == JsonValueKind.String)
                        {
                            // If the response is a string, parse it as JSON
                            var jsonString = jsonElement.GetString();
                            var jsonDocument = JsonDocument.Parse(jsonString);
                            var root = jsonDocument.RootElement;

                            createdRoomName = root.GetProperty("roomName").GetString();
                            creatorName = root.GetProperty("creatorName").GetString();
                        }
                        else if (jsonElement.ValueKind == JsonValueKind.Object)
                        {
                            // If the response is already a JSON object
                            createdRoomName = jsonElement.GetProperty("roomName").GetString();
                            creatorName = jsonElement.GetProperty("creatorName").GetString();
                        }
                        else
                        {
                            throw new InvalidOperationException("Unexpected response format");
                        }

                        await SocketManager.Instance.SetUsername(creatorName);
                        new CustomChat(createdRoomName, creatorName).Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing room creation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });

            socket.On("room error", response =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    string errorMessage = response.GetValue<string>();
                    MessageBox.Show(errorMessage, "Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            });
        }

        private async void createRoomBtn_Click(object sender, EventArgs e)
        {
            var roomName = customChatName.Text;
            var _roomCreatorName = roomCreatorName.Text;
            var chatRoomPass = roomPass.Text;

            if (string.IsNullOrWhiteSpace(roomName) || string.IsNullOrWhiteSpace(_roomCreatorName) || string.IsNullOrWhiteSpace(chatRoomPass))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                createRoomBtn.Enabled = false;
                await SocketManager.Instance.SetUsername(_roomCreatorName);
                await SocketManager.Instance.CreateRoom(roomName, chatRoomPass);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                createRoomBtn.Enabled = true;
            }
        }

        private void ExitCreateRoom_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}