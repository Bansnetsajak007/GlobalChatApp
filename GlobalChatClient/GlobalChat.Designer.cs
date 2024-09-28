namespace GlobalChatClient
{
    partial class GlobalChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcome = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.chatbox = new System.Windows.Forms.TextBox();
            this.typebox = new System.Windows.Forms.TextBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.exitChat = new System.Windows.Forms.Button();
            this.allUserList = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(117, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(323, 38);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to the chat:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(455, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(162, 38);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            // 
            // chatbox
            // 
            this.chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatbox.Location = new System.Drawing.Point(12, 70);
            this.chatbox.Multiline = true;
            this.chatbox.Name = "chatbox";
            this.chatbox.ReadOnly = true;
            this.chatbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatbox.Size = new System.Drawing.Size(605, 291);
            this.chatbox.TabIndex = 2;
            // 
            // typebox
            // 
            this.typebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typebox.Location = new System.Drawing.Point(5, 382);
            this.typebox.Multiline = true;
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(648, 69);
            this.typebox.TabIndex = 3;
            // 
            // sendMsg
            // 
            this.sendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMsg.Location = new System.Drawing.Point(659, 382);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(139, 69);
            this.sendMsg.TabIndex = 4;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // exitChat
            // 
            this.exitChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitChat.Location = new System.Drawing.Point(727, 12);
            this.exitChat.Name = "exitChat";
            this.exitChat.Size = new System.Drawing.Size(59, 35);
            this.exitChat.TabIndex = 5;
            this.exitChat.Text = "Exit";
            this.exitChat.UseVisualStyleBackColor = true;
            this.exitChat.Click += new System.EventHandler(this.exitChat_Click);
            // 
            // allUserList
            // 
            this.allUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserList.Location = new System.Drawing.Point(644, 91);
            this.allUserList.Multiline = true;
            this.allUserList.Name = "allUserList";
            this.allUserList.Size = new System.Drawing.Size(127, 254);
            this.allUserList.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserList";
            // 
            // GlobalChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allUserList);
            this.Controls.Add(this.exitChat);
            this.Controls.Add(this.sendMsg);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.welcome);
            this.Name = "GlobalChat";
            this.Text = "GlobalChat";
            this.Load += new System.EventHandler(this.GlobalChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox chatbox;
        private System.Windows.Forms.TextBox typebox;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.Button exitChat;
        private System.Windows.Forms.TextBox allUserList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}