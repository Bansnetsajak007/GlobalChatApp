using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GlobalChatClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exittohome_Click(object sender, EventArgs e)
        { 
            Home homePage = new Home();
            homePage.Show();
            this.Hide();
        }

        private void joinglobalchat_Click(object sender, EventArgs e)
        {
            var userName = userNameBox.Text;
            if (!string.IsNullOrWhiteSpace(userName))
            {

                GlobalChat globalChat = new GlobalChat(userName);
                globalChat.Show();
                this.Hide();
            }
        }
    }
}
