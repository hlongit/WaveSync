namespace MusicPlayer.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanelMain = new MusicPlayer.Resources.RoundedPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.guna2txtPass2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.guna2btnMinimizeToTray = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.roundedPanelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(156, 197);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(129, 52);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Sign up";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // roundedPanelMain
            // 
            this.roundedPanelMain.AutoSize = true;
            this.roundedPanelMain.BackColor = System.Drawing.Color.White;
            this.roundedPanelMain.BorderRadius = 20;
            this.roundedPanelMain.Controls.Add(this.panelContent);
            this.roundedPanelMain.Location = new System.Drawing.Point(104, 167);
            this.roundedPanelMain.Name = "roundedPanelMain";
            this.roundedPanelMain.Size = new System.Drawing.Size(495, 291);
            this.roundedPanelMain.TabIndex = 7;
            // 
            // panelContent
            // 
            this.panelContent.AutoSize = true;
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.Controls.Add(this.guna2txtPass2);
            this.panelContent.Controls.Add(this.guna2txtPass);
            this.panelContent.Controls.Add(this.guna2txtUser);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.btnRegister);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Location = new System.Drawing.Point(18, 19);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(458, 253);
            this.panelContent.TabIndex = 10;
            // 
            // guna2txtPass2
            // 
            this.guna2txtPass2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.guna2txtPass2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtPass2.BorderRadius = 10;
            this.guna2txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtPass2.DefaultText = "";
            this.guna2txtPass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtPass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtPass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPass2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2txtPass2.FocusedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2txtPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtPass2.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtPass2.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2txtPass2.Location = new System.Drawing.Point(214, 137);
            this.guna2txtPass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2txtPass2.Name = "guna2txtPass2";
            this.guna2txtPass2.PlaceholderText = "";
            this.guna2txtPass2.SelectedText = "";
            this.guna2txtPass2.Size = new System.Drawing.Size(240, 40);
            this.guna2txtPass2.TabIndex = 9;
            this.guna2txtPass2.UseSystemPasswordChar = true;
            // 
            // guna2txtPass
            // 
            this.guna2txtPass.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.guna2txtPass.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtPass.BorderRadius = 10;
            this.guna2txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtPass.DefaultText = "";
            this.guna2txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2txtPass.FocusedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtPass.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtPass.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2txtPass.Location = new System.Drawing.Point(214, 76);
            this.guna2txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2txtPass.Name = "guna2txtPass";
            this.guna2txtPass.PlaceholderText = "";
            this.guna2txtPass.SelectedText = "";
            this.guna2txtPass.Size = new System.Drawing.Size(240, 40);
            this.guna2txtPass.TabIndex = 8;
            this.guna2txtPass.UseSystemPasswordChar = true;
            this.guna2txtPass.TextChanged += new System.EventHandler(this.guna2txtPass_TextChanged);
            // 
            // guna2txtUser
            // 
            this.guna2txtUser.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.guna2txtUser.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtUser.BorderRadius = 10;
            this.guna2txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUser.DefaultText = "";
            this.guna2txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2txtUser.FocusedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtUser.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2txtUser.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2txtUser.Location = new System.Drawing.Point(214, 19);
            this.guna2txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2txtUser.Name = "guna2txtUser";
            this.guna2txtUser.PlaceholderText = "";
            this.guna2txtUser.SelectedText = "";
            this.guna2txtUser.Size = new System.Drawing.Size(240, 40);
            this.guna2txtUser.TabIndex = 7;
            this.guna2txtUser.TextChanged += new System.EventHandler(this.guna2txtUser_TextChanged);
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.White;
            this.panelTab.Controls.Add(this.guna2btnMinimizeToTray);
            this.panelTab.Controls.Add(this.guna2btnClose);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(700, 37);
            this.panelTab.TabIndex = 8;
            // 
            // guna2btnMinimizeToTray
            // 
            this.guna2btnMinimizeToTray.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnMinimizeToTray.BorderColor = System.Drawing.Color.Transparent;
            this.guna2btnMinimizeToTray.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMinimizeToTray.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnMinimizeToTray.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnMinimizeToTray.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnMinimizeToTray.FillColor = System.Drawing.Color.White;
            this.guna2btnMinimizeToTray.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnMinimizeToTray.ForeColor = System.Drawing.Color.Black;
            this.guna2btnMinimizeToTray.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnMinimizeToTray.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnMinimizeToTray.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnMinimizeToTray.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2btnMinimizeToTray.Location = new System.Drawing.Point(585, -12);
            this.guna2btnMinimizeToTray.Name = "guna2btnMinimizeToTray";
            this.guna2btnMinimizeToTray.Size = new System.Drawing.Size(56, 54);
            this.guna2btnMinimizeToTray.TabIndex = 33;
            this.guna2btnMinimizeToTray.Text = "–";
            this.guna2btnMinimizeToTray.Click += new System.EventHandler(this.guna2btnMinimizeToTray_Click);
            // 
            // guna2btnClose
            // 
            this.guna2btnClose.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.guna2btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnClose.FillColor = System.Drawing.Color.White;
            this.guna2btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnClose.ForeColor = System.Drawing.Color.Black;
            this.guna2btnClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnClose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.guna2btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2btnClose.Location = new System.Drawing.Point(644, -12);
            this.guna2btnClose.Name = "guna2btnClose";
            this.guna2btnClose.Size = new System.Drawing.Size(56, 54);
            this.guna2btnClose.TabIndex = 32;
            this.guna2btnClose.Text = "x";
            this.guna2btnClose.Click += new System.EventHandler(this.guna2btnClose_Click);
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "WaveSync";
            this.notifyIconApp.Click += new System.EventHandler(this.notifyIconApp_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia Pro Cond Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(700, 112);
            this.label6.TabIndex = 14;
            this.label6.Text = "WaveSync";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.roundedPanelMain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTab);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.roundedPanelMain.ResumeLayout(false);
            this.roundedPanelMain.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Resources.RoundedPanel roundedPanelMain;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtPass;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtPass2;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimizeToTray;
        private Guna.UI2.WinForms.Guna2Button guna2btnClose;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
