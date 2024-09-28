using System;

namespace GlobalChatClient
{
    partial class CustomChat
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
            this.roomName = new System.Windows.Forms.Label();
            this.dRoomName = new System.Windows.Forms.Label();
            this.customChatBox = new System.Windows.Forms.TextBox();
            this.customRoomUserList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customChatMsgBox = new System.Windows.Forms.TextBox();
            this.RoomMsgSendBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.Location = new System.Drawing.Point(190, 9);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(191, 38);
            this.roomName.TabIndex = 0;
            this.roomName.Text = "RoomName";
            // 
            // dRoomName
            // 
            this.dRoomName.AutoSize = true;
            this.dRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRoomName.Location = new System.Drawing.Point(407, 9);
            this.dRoomName.Name = "dRoomName";
            this.dRoomName.Size = new System.Drawing.Size(104, 38);
            this.dRoomName.TabIndex = 1;
            this.dRoomName.Text = "Room";
            // 
            // customChatBox
            // 
            this.customChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customChatBox.Location = new System.Drawing.Point(12, 62);
            this.customChatBox.Multiline = true;
            this.customChatBox.Name = "customChatBox";
            this.customChatBox.ReadOnly = true;
            this.customChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customChatBox.Size = new System.Drawing.Size(586, 305);
            this.customChatBox.TabIndex = 2;
            // 
            // customRoomUserList
            // 
            this.customRoomUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRoomUserList.Location = new System.Drawing.Point(635, 62);
            this.customRoomUserList.Multiline = true;
            this.customRoomUserList.Name = "customRoomUserList";
            this.customRoomUserList.Size = new System.Drawing.Size(128, 305);
            this.customRoomUserList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserList";
            // 
            // customChatMsgBox
            // 
            this.customChatMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customChatMsgBox.Location = new System.Drawing.Point(12, 383);
            this.customChatMsgBox.Multiline = true;
            this.customChatMsgBox.Name = "customChatMsgBox";
            this.customChatMsgBox.Size = new System.Drawing.Size(586, 55);
            this.customChatMsgBox.TabIndex = 5;
            // 
            // RoomMsgSendBtn
            // 
            this.RoomMsgSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomMsgSendBtn.Location = new System.Drawing.Point(635, 383);
            this.RoomMsgSendBtn.Name = "RoomMsgSendBtn";
            this.RoomMsgSendBtn.Size = new System.Drawing.Size(128, 55);
            this.RoomMsgSendBtn.TabIndex = 6;
            this.RoomMsgSendBtn.Text = "Send";
            this.RoomMsgSendBtn.UseVisualStyleBackColor = true;
            this.RoomMsgSendBtn.Click += new System.EventHandler(this.RoomMsgSendBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(21, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(66, 47);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CustomChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.RoomMsgSendBtn);
            this.Controls.Add(this.customChatMsgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customRoomUserList);
            this.Controls.Add(this.customChatBox);
            this.Controls.Add(this.dRoomName);
            this.Controls.Add(this.roomName);
            this.Name = "CustomChat";
            this.Text = "CustomChat";
            this.Load += new System.EventHandler(this.CustomChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label dRoomName;
        private System.Windows.Forms.TextBox customChatBox;
        private System.Windows.Forms.TextBox customRoomUserList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customChatMsgBox;
        private System.Windows.Forms.Button RoomMsgSendBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}