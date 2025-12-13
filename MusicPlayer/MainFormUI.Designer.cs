namespace MusicPlayer {
    partial class MainFormUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormUI));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.lblNowPlayingArtist = new System.Windows.Forms.Label();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.flowSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.AddMusicBtn = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnMinimizeToTray = new System.Windows.Forms.Button();
            this.btnUserListInfo = new System.Windows.Forms.Button();
            this.btnViewSongListInfo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.PanelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelLeft.Controls.Add(this.btnFavorites);
            this.PanelLeft.Controls.Add(this.btnUserListInfo);
            this.PanelLeft.Controls.Add(this.btnViewSongListInfo);
            this.PanelLeft.Controls.Add(this.btnHome);
            this.PanelLeft.Location = new System.Drawing.Point(0, 53);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(53, 385);
            this.PanelLeft.TabIndex = 0;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(7, 162);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(40, 23);
            this.btnFavorites.TabIndex = 6;
            this.btnFavorites.Text = "♥";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelPlayer.Controls.Add(this.btnMinimizeToTray);
            this.PanelPlayer.Controls.Add(this.btnLoop);
            this.PanelPlayer.Controls.Add(this.btnShuffle);
            this.PanelPlayer.Controls.Add(this.lblTime);
            this.PanelPlayer.Controls.Add(this.btnVolume);
            this.PanelPlayer.Controls.Add(this.volumeBar);
            this.PanelPlayer.Controls.Add(this.btnPrevious);
            this.PanelPlayer.Controls.Add(this.btnNext);
            this.PanelPlayer.Controls.Add(this.btnPlayPause);
            this.PanelPlayer.Controls.Add(this.seekBar);
            this.PanelPlayer.Controls.Add(this.lblNowPlayingArtist);
            this.PanelPlayer.Controls.Add(this.lblSongInfo);
            this.PanelPlayer.Controls.Add(this.picCover);
            this.PanelPlayer.Location = new System.Drawing.Point(0, 442);
            this.PanelPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(938, 72);
            this.PanelPlayer.TabIndex = 1;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(556, 34);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(108, 23);
            this.btnLoop.TabIndex = 24;
            this.btnLoop.Text = "Loop: OFF";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(200, 30);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(74, 25);
            this.btnShuffle.TabIndex = 23;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(508, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 25);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "00:00";
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(707, 24);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(134, 56);
            this.volumeBar.TabIndex = 7;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // seekBar
            // 
            this.seekBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seekBar.Location = new System.Drawing.Point(271, 34);
            this.seekBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(282, 56);
            this.seekBar.TabIndex = 3;
            this.seekBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseDown);
            this.seekBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseUp);
            // 
            // lblNowPlayingArtist
            // 
            this.lblNowPlayingArtist.Location = new System.Drawing.Point(78, 41);
            this.lblNowPlayingArtist.Name = "lblNowPlayingArtist";
            this.lblNowPlayingArtist.Size = new System.Drawing.Size(87, 21);
            this.lblNowPlayingArtist.TabIndex = 2;
            this.lblNowPlayingArtist.Text = "Tên ca sĩ";
            this.lblNowPlayingArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.Location = new System.Drawing.Point(77, 12);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(111, 26);
            this.lblSongInfo.TabIndex = 1;
            this.lblSongInfo.Text = "Tên bài hát";
            this.lblSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.RosyBrown;
            this.PanelContent.Controls.Add(this.flowSongs);
            this.PanelContent.Location = new System.Drawing.Point(59, 53);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(879, 385);
            this.PanelContent.TabIndex = 2;
            // 
            // flowSongs
            // 
            this.flowSongs.AutoScroll = true;
            this.flowSongs.BackColor = System.Drawing.Color.SandyBrown;
            this.flowSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSongs.Location = new System.Drawing.Point(0, 0);
            this.flowSongs.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flowSongs.Name = "flowSongs";
            this.flowSongs.Size = new System.Drawing.Size(879, 385);
            this.flowSongs.TabIndex = 0;
            this.flowSongs.WrapContents = false;
            this.flowSongs.Click += new System.EventHandler(this.flowSongs_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelTop.Controls.Add(this.btnUserInfo);
            this.PanelTop.Controls.Add(this.btnSignIn);
            this.PanelTop.Controls.Add(this.btnHistory);
            this.PanelTop.Controls.Add(this.AddMusicBtn);
            this.PanelTop.Controls.Add(this.lblUsername);
            this.PanelTop.Controls.Add(this.txtSearch);
            this.PanelTop.Controls.Add(this.picLogo);
            this.PanelTop.Controls.Add(this.btnLogout);
            this.PanelTop.Controls.Add(this.btnLogin);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(938, 48);
            this.PanelTop.TabIndex = 3;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(384, 8);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(123, 31);
            this.btnUserInfo.TabIndex = 27;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(280, 6);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(98, 35);
            this.btnSignIn.TabIndex = 20;
            this.btnSignIn.Text = "Sign In ";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(513, 8);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 31);
            this.btnHistory.TabIndex = 26;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Visible = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // AddMusicBtn
            // 
            this.AddMusicBtn.Location = new System.Drawing.Point(591, 11);
            this.AddMusicBtn.Name = "AddMusicBtn";
            this.AddMusicBtn.Size = new System.Drawing.Size(88, 28);
            this.AddMusicBtn.TabIndex = 25;
            this.AddMusicBtn.Text = "Add Music";
            this.AddMusicBtn.UseVisualStyleBackColor = true;
            this.AddMusicBtn.Click += new System.EventHandler(this.AddMusicBtn_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(268, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::MusicPlayer.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(53, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(813, 6);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(685, 5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "WaveSync";
            this.notifyIconApp.Click += new System.EventHandler(this.notifyIconApp_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::MusicPlayer.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(53, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // btnVolume
            // 
            this.btnVolume.BackgroundImage = global::MusicPlayer.Properties.Resources.volume;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnVolume.Location = new System.Drawing.Point(670, 24);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(31, 28);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPrevious.BackgroundImage = global::MusicPlayer.Properties.Resources.previous;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPrevious.Location = new System.Drawing.Point(347, 10);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(31, 28);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::MusicPlayer.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnNext.Location = new System.Drawing.Point(454, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = global::MusicPlayer.Properties.Resources.pause;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPlayPause.Location = new System.Drawing.Point(401, 10);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(31, 28);
            this.btnPlayPause.TabIndex = 5;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(11, 8);
            this.picCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(62, 56);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // btnMinimizeToTray
            // 
            this.btnMinimizeToTray.BackgroundImage = global::MusicPlayer.Properties.Resources.minimize2tray;
            this.btnMinimizeToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizeToTray.Location = new System.Drawing.Point(887, 25);
            this.btnMinimizeToTray.Name = "btnMinimizeToTray";
            this.btnMinimizeToTray.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizeToTray.TabIndex = 7;
            this.btnMinimizeToTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToTray.Click += new System.EventHandler(this.btnMinimizeToTray_Click);
            // 
            // btnUserListInfo
            // 
            this.btnUserListInfo.BackgroundImage = global::MusicPlayer.Properties.Resources.setting;
            this.btnUserListInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserListInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserListInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnUserListInfo.Location = new System.Drawing.Point(0, 107);
            this.btnUserListInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserListInfo.Name = "btnUserListInfo";
            this.btnUserListInfo.Size = new System.Drawing.Size(53, 46);
            this.btnUserListInfo.TabIndex = 5;
            this.btnUserListInfo.UseVisualStyleBackColor = true;
            this.btnUserListInfo.Click += new System.EventHandler(this.btnUserListInfo_Click);
            // 
            // btnViewSongListInfo
            // 
            this.btnViewSongListInfo.BackgroundImage = global::MusicPlayer.Properties.Resources.music;
            this.btnViewSongListInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewSongListInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSongListInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnViewSongListInfo.Location = new System.Drawing.Point(6, 58);
            this.btnViewSongListInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSongListInfo.Name = "btnViewSongListInfo";
            this.btnViewSongListInfo.Size = new System.Drawing.Size(40, 36);
            this.btnViewSongListInfo.TabIndex = 4;
            this.btnViewSongListInfo.UseVisualStyleBackColor = true;
            this.btnViewSongListInfo.Click += new System.EventHandler(this.btnViewSongListInfo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::MusicPlayer.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnHome.Location = new System.Drawing.Point(6, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 36);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(950, 515);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelPlayer);
            this.Controls.Add(this.PanelLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainFormUI";
            this.Text = "WaveSync";
            this.Load += new System.EventHandler(this.MainFormUI_Load);
            this.Resize += new System.EventHandler(this.MainFormUI_Resize);
            this.PanelLeft.ResumeLayout(false);
            this.PanelPlayer.ResumeLayout(false);
            this.PanelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelPlayer;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUserListInfo;
        private System.Windows.Forms.FlowLayoutPanel flowSongs;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.Label lblNowPlayingArtist;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button AddMusicBtn;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnViewSongListInfo;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.Button btnMinimizeToTray;
        private System.Windows.Forms.Button btnUserInfo;
    }
}

