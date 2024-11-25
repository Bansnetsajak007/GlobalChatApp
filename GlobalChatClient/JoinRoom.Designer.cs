﻿namespace GlobalChatClient
{
    partial class JoinRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joinUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.joinRoomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.joinPass = new System.Windows.Forms.TextBox();
            this.joinRoomBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Join Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name:";
            // 
            // joinUserName
            // 
            this.joinUserName.Location = new System.Drawing.Point(330, 153);
            this.joinUserName.Multiline = true;
            this.joinUserName.Name = "joinUserName";
            this.joinUserName.Size = new System.Drawing.Size(176, 25);
            this.joinUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room name:";
            // 
            // joinRoomName
            // 
            this.joinRoomName.Location = new System.Drawing.Point(330, 201);
            this.joinRoomName.Multiline = true;
            this.joinRoomName.Name = "joinRoomName";
            this.joinRoomName.Size = new System.Drawing.Size(176, 25);
            this.joinRoomName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // joinPass
            // 
            this.joinPass.Location = new System.Drawing.Point(330, 243);
            this.joinPass.Multiline = true;
            this.joinPass.Name = "joinPass";
            this.joinPass.Size = new System.Drawing.Size(176, 25);
            this.joinPass.TabIndex = 6;
            // 
            // joinRoomBtn
            // 
            this.joinRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinRoomBtn.Location = new System.Drawing.Point(330, 307);
            this.joinRoomBtn.Name = "joinRoomBtn";
            this.joinRoomBtn.Size = new System.Drawing.Size(102, 55);
            this.joinRoomBtn.TabIndex = 7;
            this.joinRoomBtn.Text = "joinRoom";
            this.joinRoomBtn.UseVisualStyleBackColor = true;
            this.joinRoomBtn.Click += new System.EventHandler(this.joinRoomBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // JoinRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.joinRoomBtn);
            this.Controls.Add(this.joinPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.joinRoomName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joinUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JoinRoom";
            this.Text = "JoinRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox joinUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox joinRoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox joinPass;
        private System.Windows.Forms.Button joinRoomBtn;
        private System.Windows.Forms.Button button2;
    }
}