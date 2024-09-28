using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GlobalChatClient
{
    public partial class CustomChat : Form
    {
        private readonly string _roomName;
        private readonly string _username;
        private bool _hasJoinedRoom = false;

        public CustomChat(string roomName, string username)
        {
            InitializeComponent();
            _roomName = roomName;
            _username = username;
        }

        private async void CustomChat_Load(object sender, EventArgs e)
        {
            SetupSocketEvents();
            if (!_hasJoinedRoom)
            {
                await JoinRoom();
                _hasJoinedRoom = true;
            }
            SetupUI();
        }

        private void SetupSocketEvents()
        {
            var socket = SocketManager.Instance.Socket;
            socket.On("room message", response =>
            {
                var jsonElement = response.GetValue<System.Text.Json.JsonElement>();
                var userName = jsonElement.GetProperty("userName").GetString();
                var message = jsonElement.GetProperty("message").GetString();
                this.Invoke((MethodInvoker)delegate
                {
                    customChatBox.AppendText($"{userName}: {message}{Environment.NewLine}");
                });
            });

            socket.On("user joined room", response =>
            {
                var username = response.GetValue<string>();
                this.Invoke((MethodInvoker)delegate
                {
                    customChatBox.AppendText($"{username} joined the room.{Environment.NewLine}");
                    if (!customRoomUserList.Lines.Contains(username))
                    {
                        customRoomUserList.AppendText($"{username}{Environment.NewLine}");
                    }
                });
            });

            socket.On("user left room", response =>
            {
                var username = response.GetValue<string>();
                this.Invoke((MethodInvoker)delegate
                {
                    customChatBox.AppendText($"{username} left the room.{Environment.NewLine}");
                    var lines = customRoomUserList.Lines.Where(line => line != username).ToArray();
                    customRoomUserList.Lines = lines;
                });
            });
        }

        private async Task JoinRoom()
        {
            try
            {
                await SocketManager.Instance.JoinRoom(_roomName, _username);
                customChatBox.AppendText($"You have joined the room: {_roomName}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error joining room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupUI()
        {
            this.Text = $"Chat Room: {_roomName} - User: {_username}";
            dRoomName.Text = _roomName;
        }

        private async void RoomMsgSendBtn_Click(object sender, EventArgs e)
        {
            string message = customChatMsgBox.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                try
                {
                    await SocketManager.Instance.SendRoomMessage(message);
                    customChatMsgBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await SocketManager.Instance.LeaveRoom();
                this.Close();
                Application.OpenForms.OfType<JoinRoom>().FirstOrDefault()?.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error leaving room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}