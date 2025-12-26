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
            this.roundedPanelMain = new MusicPlayer.RoundedPanel();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.guna2btnMinimizeToTray = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.roundedPanelMain.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(214, 183);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 55);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // roundedPanelMain
            // 
            this.roundedPanelMain.BackColor = System.Drawing.Color.White;
            this.roundedPanelMain.BorderRadius = 20;
            this.roundedPanelMain.Controls.Add(this.txtPass2);
            this.roundedPanelMain.Controls.Add(this.txtPass);
            this.roundedPanelMain.Controls.Add(this.txtUser);
            this.roundedPanelMain.Controls.Add(this.label3);
            this.roundedPanelMain.Controls.Add(this.btnRegister);
            this.roundedPanelMain.Controls.Add(this.label1);
            this.roundedPanelMain.Controls.Add(this.label2);
            this.roundedPanelMain.Location = new System.Drawing.Point(59, 181);
            this.roundedPanelMain.Name = "roundedPanelMain";
            this.roundedPanelMain.Size = new System.Drawing.Size(582, 256);
            this.roundedPanelMain.TabIndex = 7;
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtPass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(263, 132);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(268, 34);
            this.txtPass2.TabIndex = 12;
            this.txtPass2.UseSystemPasswordChar = true;
            this.txtPass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass2_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(263, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(268, 34);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(263, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(268, 34);
            this.txtUser.TabIndex = 10;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
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
            this.label6.Font = new System.Drawing.Font("Georgia Pro Cond Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(700, 124);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.roundedPanelMain);
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
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundedPanel roundedPanelMain;
        private System.Windows.Forms.Panel panelTab;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimizeToTray;
        private Guna.UI2.WinForms.Guna2Button guna2btnClose;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPass2;
    }
}
