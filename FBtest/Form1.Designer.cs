namespace FBtest
{
    partial class Form1
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.btFetchAlbum = new System.Windows.Forms.Button();
            this.btFetchCheckins = new System.Windows.Forms.Button();
            this.btFetchEvents = new System.Windows.Forms.Button();
            this.btFetchFriends = new System.Windows.Forms.Button();
            this.btPost = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.listBoxAlbum = new System.Windows.Forms.ListBox();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(27, 18);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(128, 32);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btFetchAlbum
            // 
            this.btFetchAlbum.Location = new System.Drawing.Point(27, 186);
            this.btFetchAlbum.Name = "btFetchAlbum";
            this.btFetchAlbum.Size = new System.Drawing.Size(158, 32);
            this.btFetchAlbum.TabIndex = 2;
            this.btFetchAlbum.Text = "Fetch Album";
            this.btFetchAlbum.UseVisualStyleBackColor = true;
            this.btFetchAlbum.Click += new System.EventHandler(this.btFetchAlbum_Click);
            // 
            // btFetchCheckins
            // 
            this.btFetchCheckins.Location = new System.Drawing.Point(240, 186);
            this.btFetchCheckins.Name = "btFetchCheckins";
            this.btFetchCheckins.Size = new System.Drawing.Size(163, 32);
            this.btFetchCheckins.TabIndex = 4;
            this.btFetchCheckins.Text = "Fetch Checkins";
            this.btFetchCheckins.UseVisualStyleBackColor = true;
            this.btFetchCheckins.Click += new System.EventHandler(this.btFetchCheckins_Click);
            // 
            // btFetchEvents
            // 
            this.btFetchEvents.Location = new System.Drawing.Point(452, 186);
            this.btFetchEvents.Name = "btFetchEvents";
            this.btFetchEvents.Size = new System.Drawing.Size(163, 32);
            this.btFetchEvents.TabIndex = 6;
            this.btFetchEvents.Text = "Fetch Events";
            this.btFetchEvents.UseVisualStyleBackColor = true;
            this.btFetchEvents.Click += new System.EventHandler(this.btFetchEvents_Click);
            // 
            // btFetchFriends
            // 
            this.btFetchFriends.Location = new System.Drawing.Point(27, 339);
            this.btFetchFriends.Name = "btFetchFriends";
            this.btFetchFriends.Size = new System.Drawing.Size(158, 32);
            this.btFetchFriends.TabIndex = 8;
            this.btFetchFriends.Text = "Fetch Friends";
            this.btFetchFriends.UseVisualStyleBackColor = true;
            this.btFetchFriends.Click += new System.EventHandler(this.btFetchFriends_Click);
            // 
            // btPost
            // 
            this.btPost.Location = new System.Drawing.Point(452, 18);
            this.btPost.Name = "btPost";
            this.btPost.Size = new System.Drawing.Size(163, 32);
            this.btPost.TabIndex = 10;
            this.btPost.Text = "Post";
            this.btPost.UseVisualStyleBackColor = true;
            this.btPost.Click += new System.EventHandler(this.btPost_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(27, 56);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(128, 103);
            this.pictureBoxProfile.TabIndex = 11;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(191, 377);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(64, 59);
            this.pictureBoxFriendProfile.TabIndex = 12;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // listBoxAlbum
            // 
            this.listBoxAlbum.FormattingEnabled = true;
            this.listBoxAlbum.Location = new System.Drawing.Point(27, 224);
            this.listBoxAlbum.Name = "listBoxAlbum";
            this.listBoxAlbum.Size = new System.Drawing.Size(158, 95);
            this.listBoxAlbum.TabIndex = 13;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(240, 224);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(163, 95);
            this.listBoxCheckIns.TabIndex = 14;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(452, 224);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(163, 95);
            this.listBoxEvents.TabIndex = 15;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(27, 377);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(158, 95);
            this.listBoxFriends.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 481);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.listBoxAlbum);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btPost);
            this.Controls.Add(this.btFetchFriends);
            this.Controls.Add(this.btFetchEvents);
            this.Controls.Add(this.btFetchCheckins);
            this.Controls.Add(this.btFetchAlbum);
            this.Controls.Add(this.bt_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button btFetchAlbum;
        private System.Windows.Forms.Button btFetchCheckins;
        private System.Windows.Forms.Button btFetchEvents;
        private System.Windows.Forms.Button btFetchFriends;
        private System.Windows.Forms.Button btPost;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.ListBox listBoxAlbum;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBox1;
    }
}

