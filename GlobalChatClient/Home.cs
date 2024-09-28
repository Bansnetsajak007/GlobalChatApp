using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalChatClient
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void globalchat_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
            loginForm.FormClosed += (s, args) => this.Show();
        }

        private void createroom_Click(object sender, EventArgs e)
        {

            CreateLogin createLogin = new CreateLogin();
            createLogin.Show();
            this.Hide();
        }

        private void joinroom_Click(object sender, EventArgs e)
        {
            JoinRoom joinroom = new JoinRoom();
            joinroom.Show();
            this.Hide();
        }
    }
}
