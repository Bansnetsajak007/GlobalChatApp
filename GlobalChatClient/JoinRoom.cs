using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GlobalChatClient
{
    public partial class JoinRoom : Form
    {
        private bool _isJoining = false;
        private Dictionary<string, CustomChat> _activeChats = new Dictionary<string, CustomChat>();

        public JoinRoom()
        {
            InitializeComponent();
            InitializeSocket();
        }

        private void InitializeSocket()
        {
            var socket = SocketManager.Instance.Socket;
            socket.On("room joined", response =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    string joinedRoom = response.GetValue<string>();
                    OpenOrFocusCustomChat(joinedRoom, joinUserName.Text);
                });
            });

            socket.On("room error", response =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    string errorMessage = response.GetValue<string>();
                    MessageBox.Show(errorMessage, "Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isJoining = false;
                    joinRoomBtn.Enabled = true;
                });
            });
        }

        private void OpenOrFocusCustomChat(string roomName, string username)
        {
            if (_activeChats.TryGetValue(roomName, out CustomChat existingChat))
            {
                existingChat.BringToFront();
                existingChat.Focus();
            }
            else
            {
                CustomChat newChat = new CustomChat(roomName, username);
                _activeChats[roomName] = newChat;
                newChat.FormClosed += (s, args) => _activeChats.Remove(roomName);
                newChat.Show();
            }
            this.Hide();
            _isJoining = false;
            joinRoomBtn.Enabled = true;
        }

        private async void joinRoomBtn_Click(object sender, EventArgs e)
        {
            if (_isJoining) return; // Prevent multiple clicks

            _isJoining = true;
            joinRoomBtn.Enabled = false;

            try
            {
                var joinedUser = joinUserName.Text;
                var roomName = joinRoomName.Text;
                var pass = joinPass.Text;

                if (string.IsNullOrWhiteSpace(joinedUser) || string.IsNullOrWhiteSpace(roomName) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Please enter username, room name, and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _isJoining = false;
                    joinRoomBtn.Enabled = true;
                    return;
                }

                await SocketManager.Instance.SetUsername(joinedUser);
                await SocketManager.Instance.JoinRoom(roomName, joinedUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error joining room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isJoining = false;
                joinRoomBtn.Enabled = true;
            }
        }
    }
}