namespace Interface
{
    partial class MainForm
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
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.trackProgress = new System.Windows.Forms.TrackBar();
            this.lblNowPlayingArtist = new System.Windows.Forms.Label();
            this.lblNowPlayingTitle = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.flowSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.picNowPlayingCover = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.PanelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackProgress)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNowPlayingCover)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelLeft.Controls.Add(this.btnSetting);
            this.PanelLeft.Controls.Add(this.btnSongs);
            this.PanelLeft.Controls.Add(this.btnHome);
            this.PanelLeft.Controls.Add(this.panel1);
            this.PanelLeft.Controls.Add(this.panel3);
            this.PanelLeft.Controls.Add(this.panel2);
            this.PanelLeft.Location = new System.Drawing.Point(0, 66);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(60, 481);
            this.PanelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 567);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 75);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 74);
            this.panel2.TabIndex = 1;
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelPlayer.Controls.Add(this.btnVolume);
            this.PanelPlayer.Controls.Add(this.trackVolume);
            this.PanelPlayer.Controls.Add(this.btnPrev);
            this.PanelPlayer.Controls.Add(this.btnNext);
            this.PanelPlayer.Controls.Add(this.btnPlayPause);
            this.PanelPlayer.Controls.Add(this.trackProgress);
            this.PanelPlayer.Controls.Add(this.lblNowPlayingArtist);
            this.PanelPlayer.Controls.Add(this.lblNowPlayingTitle);
            this.PanelPlayer.Controls.Add(this.picNowPlayingCover);
            this.PanelPlayer.Location = new System.Drawing.Point(0, 553);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(958, 90);
            this.PanelPlayer.TabIndex = 1;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(795, 30);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(151, 69);
            this.trackVolume.TabIndex = 7;
            // 
            // trackProgress
            // 
            this.trackProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackProgress.Location = new System.Drawing.Point(305, 43);
            this.trackProgress.Name = "trackProgress";
            this.trackProgress.Size = new System.Drawing.Size(317, 69);
            this.trackProgress.TabIndex = 3;
            // 
            // lblNowPlayingArtist
            // 
            this.lblNowPlayingArtist.Location = new System.Drawing.Point(88, 51);
            this.lblNowPlayingArtist.Name = "lblNowPlayingArtist";
            this.lblNowPlayingArtist.Size = new System.Drawing.Size(98, 26);
            this.lblNowPlayingArtist.TabIndex = 2;
            this.lblNowPlayingArtist.Text = "Tên ca sĩ";
            this.lblNowPlayingArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNowPlayingArtist.Click += new System.EventHandler(this.lblNowPlayingArtist_Click);
            // 
            // lblNowPlayingTitle
            // 
            this.lblNowPlayingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlayingTitle.Location = new System.Drawing.Point(87, 15);
            this.lblNowPlayingTitle.Name = "lblNowPlayingTitle";
            this.lblNowPlayingTitle.Size = new System.Drawing.Size(125, 32);
            this.lblNowPlayingTitle.TabIndex = 1;
            this.lblNowPlayingTitle.Text = "Tên bài hát";
            this.lblNowPlayingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNowPlayingTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.RosyBrown;
            this.PanelContent.Controls.Add(this.flowSongs);
            this.PanelContent.Location = new System.Drawing.Point(66, 66);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(892, 481);
            this.PanelContent.TabIndex = 2;
            // 
            // flowSongs
            // 
            this.flowSongs.AutoScroll = true;
            this.flowSongs.BackColor = System.Drawing.Color.SandyBrown;
            this.flowSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSongs.Location = new System.Drawing.Point(0, 0);
            this.flowSongs.Name = "flowSongs";
            this.flowSongs.Size = new System.Drawing.Size(892, 481);
            this.flowSongs.TabIndex = 0;
            this.flowSongs.WrapContents = false;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelTop.Controls.Add(this.picLogo);
            this.PanelTop.Controls.Add(this.btnLogout);
            this.PanelTop.Controls.Add(this.btnLogin);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(958, 60);
            this.PanelTop.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(814, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(663, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Interface.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnVolume
            // 
            this.btnVolume.BackgroundImage = global::Interface.Properties.Resources.volume;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnVolume.Location = new System.Drawing.Point(754, 30);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(35, 35);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPrev.BackgroundImage = global::Interface.Properties.Resources.previous;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPrev.Location = new System.Drawing.Point(390, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Interface.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnNext.Location = new System.Drawing.Point(511, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = global::Interface.Properties.Resources.pause;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPlayPause.Location = new System.Drawing.Point(451, 12);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(35, 35);
            this.btnPlayPause.TabIndex = 5;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            // 
            // picNowPlayingCover
            // 
            this.picNowPlayingCover.Location = new System.Drawing.Point(12, 10);
            this.picNowPlayingCover.Name = "picNowPlayingCover";
            this.picNowPlayingCover.Size = new System.Drawing.Size(70, 70);
            this.picNowPlayingCover.TabIndex = 0;
            this.picNowPlayingCover.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = global::Interface.Properties.Resources.setting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnSetting.Location = new System.Drawing.Point(0, 134);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(60, 58);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnSongs
            // 
            this.btnSongs.BackgroundImage = global::Interface.Properties.Resources.music;
            this.btnSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnSongs.Location = new System.Drawing.Point(7, 73);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(45, 45);
            this.btnSongs.TabIndex = 4;
            this.btnSongs.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Interface.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnHome.Location = new System.Drawing.Point(7, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 45);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(958, 644);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelPlayer);
            this.Controls.Add(this.PanelLeft);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.PanelLeft.ResumeLayout(false);
            this.PanelPlayer.ResumeLayout(false);
            this.PanelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackProgress)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNowPlayingCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.FlowLayoutPanel flowSongs;
        private System.Windows.Forms.PictureBox picNowPlayingCover;
        private System.Windows.Forms.Label lblNowPlayingTitle;
        private System.Windows.Forms.Label lblNowPlayingArtist;
        private System.Windows.Forms.TrackBar trackProgress;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

