namespace MusicPlayer.Forms {
    partial class AddMusicForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMusicForm));
            this.label6 = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.guna2btnMinimizeToTray = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.roundedPanel1 = new MusicPlayer.RoundedPanel();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.CoverPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MusicPathButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CoverPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTab.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia Pro Cond Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(820, 124);
            this.label6.TabIndex = 13;
            this.label6.Text = "WaveSync";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.White;
            this.panelTab.Controls.Add(this.guna2btnMinimizeToTray);
            this.panelTab.Controls.Add(this.guna2btnClose);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(820, 37);
            this.panelTab.TabIndex = 14;
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
            this.guna2btnMinimizeToTray.Location = new System.Drawing.Point(705, -12);
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
            this.guna2btnClose.Location = new System.Drawing.Point(764, -12);
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
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.btnAddMusic);
            this.roundedPanel1.Controls.Add(this.CoverPathButton);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.MusicPathButton);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.CoverPath);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.txtPath);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.txtAlbum);
            this.roundedPanel1.Controls.Add(this.txtArtist);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.txtTitle);
            this.roundedPanel1.Location = new System.Drawing.Point(111, 187);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(600, 327);
            this.roundedPanel1.TabIndex = 12;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusic.Location = new System.Drawing.Point(257, 256);
            this.btnAddMusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(84, 54);
            this.btnAddMusic.TabIndex = 6;
            this.btnAddMusic.Text = "Add";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // CoverPathButton
            // 
            this.CoverPathButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoverPathButton.Location = new System.Drawing.Point(428, 200);
            this.CoverPathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoverPathButton.Name = "CoverPathButton";
            this.CoverPathButton.Size = new System.Drawing.Size(134, 39);
            this.CoverPathButton.TabIndex = 5;
            this.CoverPathButton.Text = "Browse cover";
            this.CoverPathButton.UseVisualStyleBackColor = true;
            this.CoverPathButton.Click += new System.EventHandler(this.CoverPathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Song Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MusicPathButton
            // 
            this.MusicPathButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicPathButton.Location = new System.Drawing.Point(428, 157);
            this.MusicPathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MusicPathButton.Name = "MusicPathButton";
            this.MusicPathButton.Size = new System.Drawing.Size(134, 39);
            this.MusicPathButton.TabIndex = 4;
            this.MusicPathButton.Text = "Browse .mp3";
            this.MusicPathButton.UseVisualStyleBackColor = true;
            this.MusicPathButton.Click += new System.EventHandler(this.MusicPathButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artist Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoverPath
            // 
            this.CoverPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.CoverPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoverPath.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoverPath.Location = new System.Drawing.Point(201, 206);
            this.CoverPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoverPath.Name = "CoverPath";
            this.CoverPath.Size = new System.Drawing.Size(205, 29);
            this.CoverPath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(201, 163);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(205, 29);
            this.txtPath.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cover Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.Location = new System.Drawing.Point(201, 118);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(205, 29);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(201, 74);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(205, 29);
            this.txtArtist.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Audio File Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(201, 29);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 29);
            this.txtTitle.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // AddMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 557);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundedPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddMusicForm";
            this.Text = "AddMusicForm";
            this.panelTab.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CoverPath;
        private System.Windows.Forms.Button MusicPathButton;
        private System.Windows.Forms.Button CoverPathButton;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTab;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimizeToTray;
        private Guna.UI2.WinForms.Guna2Button guna2btnClose;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
