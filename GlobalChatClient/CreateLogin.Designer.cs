namespace GlobalChatClient
{
    partial class CreateLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.customChatName = new System.Windows.Forms.TextBox();
            this.CustomRoomPass = new System.Windows.Forms.Label();
            this.roomPass = new System.Windows.Forms.TextBox();
            this.createRoomBtn = new System.Windows.Forms.Button();
            this.ExitCreateRoom = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.roomCreatorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Chat Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room name: ";
            // 
            // customChatName
            // 
            this.customChatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customChatName.Location = new System.Drawing.Point(353, 241);
            this.customChatName.Multiline = true;
            this.customChatName.Name = "customChatName";
            this.customChatName.Size = new System.Drawing.Size(172, 29);
            this.customChatName.TabIndex = 3;
            // 
            // CustomRoomPass
            // 
            this.CustomRoomPass.AutoSize = true;
            this.CustomRoomPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRoomPass.Location = new System.Drawing.Point(191, 276);
            this.CustomRoomPass.Name = "CustomRoomPass";
            this.CustomRoomPass.Size = new System.Drawing.Size(126, 29);
            this.CustomRoomPass.TabIndex = 4;
            this.CustomRoomPass.Text = "Password:";
            // 
            // roomPass
            // 
            this.roomPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPass.Location = new System.Drawing.Point(353, 276);
            this.roomPass.Multiline = true;
            this.roomPass.Name = "roomPass";
            this.roomPass.Size = new System.Drawing.Size(172, 29);
            this.roomPass.TabIndex = 5;
            // 
            // createRoomBtn
            // 
            this.createRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRoomBtn.Location = new System.Drawing.Point(320, 325);
            this.createRoomBtn.Name = "createRoomBtn";
            this.createRoomBtn.Size = new System.Drawing.Size(109, 56);
            this.createRoomBtn.TabIndex = 6;
            this.createRoomBtn.Text = "Create";
            this.createRoomBtn.UseVisualStyleBackColor = true;
            this.createRoomBtn.Click += new System.EventHandler(this.createRoomBtn_Click);
            // 
            // ExitCreateRoom
            // 
            this.ExitCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCreateRoom.Location = new System.Drawing.Point(22, 382);
            this.ExitCreateRoom.Name = "ExitCreateRoom";
            this.ExitCreateRoom.Size = new System.Drawing.Size(62, 37);
            this.ExitCreateRoom.TabIndex = 7;
            this.ExitCreateRoom.Text = "Exit";
            this.ExitCreateRoom.UseVisualStyleBackColor = true;
            this.ExitCreateRoom.Click += new System.EventHandler(this.ExitCreateRoom_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(191, 198);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(142, 29);
            this.userName.TabIndex = 8;
            this.userName.Text = "Username:  ";
            // 
            // roomCreatorName
            // 
            this.roomCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCreatorName.Location = new System.Drawing.Point(353, 206);
            this.roomCreatorName.Multiline = true;
            this.roomCreatorName.Name = "roomCreatorName";
            this.roomCreatorName.Size = new System.Drawing.Size(172, 29);
            this.roomCreatorName.TabIndex = 9;
            // 
            // CreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomCreatorName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.ExitCreateRoom);
            this.Controls.Add(this.createRoomBtn);
            this.Controls.Add(this.roomPass);
            this.Controls.Add(this.CustomRoomPass);
            this.Controls.Add(this.customChatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateLogin";
            this.Text = "CreateLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customChatName;
        private System.Windows.Forms.Label CustomRoomPass;
        private System.Windows.Forms.TextBox roomPass;
        private System.Windows.Forms.Button createRoomBtn;
        private System.Windows.Forms.Button ExitCreateRoom;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox roomCreatorName;
    }
}