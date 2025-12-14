using System;
using System.Drawing;
using System.Windows.Forms;

partial class UserInfoControl
{
    private PictureBox picAvatar;
    private Label lblUsername;
    private Button btnSettings;

    private void InitializeComponent()
    {
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(10, 10);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(70, 70);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(90, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username";
            this.lblUsername.Size = new System.Drawing.Size(0, 25);
            this.lblUsername.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(230, 25);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "⚙ Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            //
            // UserInfoControl
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSettings);
            this.Name = "UserInfoControl";
            this.Size = new System.Drawing.Size(320, 94);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
