using System;
using System.Threading.Tasks;
using SocketIOClient;

namespace GlobalChatClient
{
    public class SocketManager
    {
        private static SocketManager _instance;
        public SocketIOClient.SocketIO Socket { get; private set; }
        private TaskCompletionSource<bool> _connectionTcs;
        private string _currentUsername;
        private string _currentRoom;
        private bool _isJoiningRoom = false;

        private SocketManager()
        {
            Socket = new SocketIOClient.SocketIO("http://localhost:6969");
            _connectionTcs = new TaskCompletionSource<bool>();
            Socket.OnConnected += (sender, e) => _connectionTcs.TrySetResult(true);
            Socket.OnDisconnected += (sender, e) => _connectionTcs = new TaskCompletionSource<bool>();
            Socket.ConnectAsync();
        }

        public static SocketManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SocketManager();
                }
                return _instance;
            }
        }

        private async Task EnsureConnectedAsync()
        {
            if (!Socket.Connected) await _connectionTcs.Task;
        }

        public async Task SetUsername(string username)
        {
            await EnsureConnectedAsync();
            _currentUsername = username;
            await Socket.EmitAsync("set username", username);
        }

        public async Task CreateRoom(string roomName, string password)
        {
            await EnsureConnectedAsync();
            await Socket.EmitAsync("create room", new { roomName, password });
        }

        public async Task JoinRoom(string roomName, string username)
        {
            await EnsureConnectedAsync();
            if (_isJoiningRoom) return; // Prevent multiple join attempts

            _isJoiningRoom = true;
            try
            {
                _currentUsername = username;
                _currentRoom = roomName;
                await Socket.EmitAsync("join room", new { roomName, username });
            }
            finally
            {
                _isJoiningRoom = false;
            }
        }

        public async Task SendRoomMessage(string message)
        {
            await EnsureConnectedAsync();
            if (string.IsNullOrEmpty(_currentRoom))
                throw new InvalidOperationException("Not currently in a room");
            await Socket.EmitAsync("room message", new { roomName = _currentRoom, message });
        }

        public async Task LeaveRoom()
        {
            await EnsureConnectedAsync();
            if (string.IsNullOrEmpty(_currentRoom) || string.IsNullOrEmpty(_currentUsername))
                throw new InvalidOperationException("Not currently in a room");
            await Socket.EmitAsync("leave room", new { roomName = _currentRoom, username = _currentUsername });
            _currentRoom = null;
            _currentUsername = null;
        }
    }
}