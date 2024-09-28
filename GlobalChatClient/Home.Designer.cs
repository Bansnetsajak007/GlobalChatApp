namespace GlobalChatClient
{
    partial class Home
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
            this.globalchat = new System.Windows.Forms.Button();
            this.createroom = new System.Windows.Forms.Button();
            this.joinroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global Chat";
            // 
            // globalchat
            // 
            this.globalchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalchat.Location = new System.Drawing.Point(292, 193);
            this.globalchat.Name = "globalchat";
            this.globalchat.Size = new System.Drawing.Size(156, 60);
            this.globalchat.TabIndex = 1;
            this.globalchat.Text = "Join Global Chat";
            this.globalchat.UseVisualStyleBackColor = true;
            this.globalchat.Click += new System.EventHandler(this.globalchat_Click);
            // 
            // createroom
            // 
            this.createroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createroom.Location = new System.Drawing.Point(292, 259);
            this.createroom.Name = "createroom";
            this.createroom.Size = new System.Drawing.Size(156, 60);
            this.createroom.TabIndex = 2;
            this.createroom.Text = "Create room";
            this.createroom.UseVisualStyleBackColor = true;
            this.createroom.Click += new System.EventHandler(this.createroom_Click);
            // 
            // joinroom
            // 
            this.joinroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinroom.Location = new System.Drawing.Point(292, 325);
            this.joinroom.Name = "joinroom";
            this.joinroom.Size = new System.Drawing.Size(156, 60);
            this.joinroom.TabIndex = 3;
            this.joinroom.Text = "Join Room";
            this.joinroom.UseVisualStyleBackColor = true;
            this.joinroom.Click += new System.EventHandler(this.joinroom_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joinroom);
            this.Controls.Add(this.createroom);
            this.Controls.Add(this.globalchat);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button globalchat;
        private System.Windows.Forms.Button createroom;
        private System.Windows.Forms.Button joinroom;
    }
}

