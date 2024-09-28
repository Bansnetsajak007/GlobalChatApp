using System;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace GlobalChatClient
{
    public partial class GlobalChat : Form
    {
        private SocketIOClient.SocketIO socket;
        private string _userName;
        public GlobalChat(string userName)
        {
            InitializeComponent();
            _userName = userName;
            InitializeSocket();
        }

        //custom function to delete name from list
        private void DeleteNameByLine(string lineContent)
        {
            var lines = allUserList.Lines.ToList();
            int lineIndex = lines.FindIndex(line => line == lineContent);

            if (lineIndex != -1) 
            {
                lines.RemoveAt(lineIndex); 
                allUserList.Lines = lines.ToArray();
            }
        }

        private void InitializeSocket()
        {
            string realName;
            socket = new SocketIOClient.SocketIO("http://localhost:5000");

            socket.OnConnected += async (s, args) =>
            {
                //emitting the event to socket
                await socket.EmitAsync("set username", _userName);
                await socket.EmitAsync("broadcast");
                this.Invoke((MethodInvoker)delegate
                {
                    chatbox.AppendText("Connected to the server.\r\n");
                });
            };

            socket.On("broadcast", (response) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        var jsonElement = response.GetValue<JsonElement>();
                        var joinedUser = jsonElement.GetProperty("joinedUserData").GetString();
                        allUserList.AppendText($"{joinedUser}\r\n");
                        if (joinedUser != _userName)
                        {
                            chatbox.AppendText($"{joinedUser} joined the chat.\r\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        chatbox.AppendText($"Error: {ex.Message}\r\n");
                    }
                });
            });
           
            socket.On("user disconnected", (response) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        var username = response.GetValue<string>();
                        DeleteNameByLine(username);
                        if (username != _userName)
                        {
                            chatbox.AppendText($"{username} has left the chat\r\n");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        chatbox.AppendText($"Error: {ex.Message}\r\n");
                    }
                });
            });

            socket.On("chat message", (response) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        var jsonElement = response.GetValue<JsonElement>();
                        var username = jsonElement.GetProperty("userName").GetString();
                        var message = jsonElement.GetProperty("message").GetString();
                        if (username == _userName)
                        {
                            realName = "you";
                            chatbox.AppendText($"{realName}: {message}\r\n");
                        }
                        else
                        {
                            chatbox.AppendText($"{username}: {message}\r\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        chatbox.AppendText($"Error parsing message: {ex.Message}\r\n");
                    }
                });
            });
        }

        private async void GlobalChat_Load(object sender, EventArgs e)
        {
            username.Text = _userName;

            try
            {
                await socket.ConnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        private async void sendMsg_Click(object sender, EventArgs e)
        {
            var message = typebox.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                try
                {
                    await socket.EmitAsync("chat message", message);
                    typebox.Clear();
                    typebox.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error sending message: {ex.Message}");
                }
            } 
            else
            {
                MessageBox.Show($"Text Box is Empty!");
            }
            
        }

        private void exitChat_Click(object sender, EventArgs e)
        {
            socket.DisconnectAsync();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
