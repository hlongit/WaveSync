namespace MusicPlayer.Forms
{
    partial class ChangeNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeNameForm));
            this.panelTab = new System.Windows.Forms.Panel();
            this.guna2btnMinimizeToTray = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundedPanel1 = new MusicPlayer.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTab.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.White;
            this.panelTab.Controls.Add(this.guna2btnMinimizeToTray);
            this.panelTab.Controls.Add(this.guna2btnClose);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(530, 37);
            this.panelTab.TabIndex = 15;
            this.panelTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTab_MouseDown);
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
            this.guna2btnMinimizeToTray.Location = new System.Drawing.Point(415, -12);
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
            this.guna2btnClose.Location = new System.Drawing.Point(474, -12);
            this.guna2btnClose.Name = "guna2btnClose";
            this.guna2btnClose.Size = new System.Drawing.Size(56, 54);
            this.guna2btnClose.TabIndex = 32;
            this.guna2btnClose.Text = "x";
            this.guna2btnClose.Click += new System.EventHandler(this.guna2btnClose_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(150, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(157, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 19);
            this.textBox1.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.textBox1);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.button1);
            this.roundedPanel1.Location = new System.Drawing.Point(64, 155);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(408, 152);
            this.roundedPanel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia Pro Cond Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(130, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 60);
            this.label6.TabIndex = 17;
            this.label6.Text = "WaveSync";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "WaveSync";
            this.notifyIconApp.Click += new System.EventHandler(this.notifyIconApp_Click);
            // 
            // ChangeNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panelTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeNameForm";
            this.Text = "ChangeNameForm";
            this.panelTab.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTab;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimizeToTray;
        private Guna.UI2.WinForms.Guna2Button guna2btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
    }
}