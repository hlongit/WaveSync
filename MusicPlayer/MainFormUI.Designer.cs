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
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.guna2TrackBarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2TrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblNowPlayingArtist = new System.Windows.Forms.Label();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.PanelTab = new System.Windows.Forms.Panel();
            this.guna2btnMinimizeToTray = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.guna2btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.notifyIconApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlAddMusics = new System.Windows.Forms.Panel();
            this.btnAddMusics = new System.Windows.Forms.Button();
            this.pnlFavor = new System.Windows.Forms.Panel();
            this.btnFavor = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.settingsTransitions = new System.Windows.Forms.Timer(this.components);
            this.SideBarTransitions = new System.Windows.Forms.Timer(this.components);
            this.textScrollTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.roundedPanelMain = new MusicPlayer.Resources.RoundedPanel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.flowSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlAddMusics.SuspendLayout();
            this.pnlFavor.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.SettingsContainer.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlLogOut.SuspendLayout();
            this.roundedPanelMain.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.BackColor = System.Drawing.Color.White;
            this.PanelPlayer.Controls.Add(this.btnPlayPause);
            this.PanelPlayer.Controls.Add(this.btnLoop);
            this.PanelPlayer.Controls.Add(this.btnShuffle);
            this.PanelPlayer.Controls.Add(this.btnPrevious);
            this.PanelPlayer.Controls.Add(this.btnNext);
            this.PanelPlayer.Controls.Add(this.guna2TrackBarVolume);
            this.PanelPlayer.Controls.Add(this.guna2TrackBar);
            this.PanelPlayer.Controls.Add(this.lblTime);
            this.PanelPlayer.Controls.Add(this.btnVolume);
            this.PanelPlayer.Controls.Add(this.lblNowPlayingArtist);
            this.PanelPlayer.Controls.Add(this.lblSongInfo);
            this.PanelPlayer.Controls.Add(this.picCover);
            this.PanelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPlayer.Location = new System.Drawing.Point(0, 590);
            this.PanelPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(1053, 111);
            this.PanelPlayer.TabIndex = 1;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.Image = global::MusicPlayer.Properties.Resources.play;
            this.btnPlayPause.Location = new System.Drawing.Point(509, 26);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(45, 45);
            this.btnPlayPause.TabIndex = 5;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoop.BackgroundImage")));
            this.btnLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoop.Location = new System.Drawing.Point(610, 29);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(36, 36);
            this.btnLoop.TabIndex = 24;
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.BackgroundImage")));
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffle.Location = new System.Drawing.Point(411, 29);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(36, 36);
            this.btnShuffle.TabIndex = 23;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::MusicPlayer.Properties.Resources.previous;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Location = new System.Drawing.Point(468, 33);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::MusicPlayer.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(560, 33);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2TrackBarVolume
            // 
            this.guna2TrackBarVolume.HoverState.ThumbColor = System.Drawing.Color.CornflowerBlue;
            this.guna2TrackBarVolume.Location = new System.Drawing.Point(888, 41);
            this.guna2TrackBarVolume.Name = "guna2TrackBarVolume";
            this.guna2TrackBarVolume.Size = new System.Drawing.Size(149, 35);
            this.guna2TrackBarVolume.TabIndex = 28;
            this.guna2TrackBarVolume.ThumbColor = System.Drawing.Color.Black;
            this.guna2TrackBarVolume.Value = 70;
            this.guna2TrackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBarVolume_Scroll);
            // 
            // guna2TrackBar
            // 
            this.guna2TrackBar.HoverState.ThumbColor = System.Drawing.Color.CornflowerBlue;
            this.guna2TrackBar.Location = new System.Drawing.Point(384, 64);
            this.guna2TrackBar.Maximum = 10;
            this.guna2TrackBar.Name = "guna2TrackBar";
            this.guna2TrackBar.Size = new System.Drawing.Size(294, 35);
            this.guna2TrackBar.TabIndex = 27;
            this.guna2TrackBar.ThumbColor = System.Drawing.Color.Black;
            this.guna2TrackBar.Value = 10;
            this.guna2TrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar_Scroll);
            this.guna2TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2TrackBar_MouseDown);
            this.guna2TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2TrackBar_MouseUp);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(689, 67);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 28);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "00:00";
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundImage = global::MusicPlayer.Properties.Resources.volume;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolume.Location = new System.Drawing.Point(823, 41);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(59, 35);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblNowPlayingArtist
            // 
            this.lblNowPlayingArtist.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlayingArtist.Location = new System.Drawing.Point(114, 64);
            this.lblNowPlayingArtist.Name = "lblNowPlayingArtist";
            this.lblNowPlayingArtist.Size = new System.Drawing.Size(242, 26);
            this.lblNowPlayingArtist.TabIndex = 2;
            this.lblNowPlayingArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.Location = new System.Drawing.Point(113, 28);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(249, 32);
            this.lblSongInfo.TabIndex = 1;
            this.lblSongInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(12, 15);
            this.picCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(82, 85);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // PanelTab
            // 
            this.PanelTab.BackColor = System.Drawing.Color.White;
            this.PanelTab.Controls.Add(this.guna2btnMinimizeToTray);
            this.PanelTab.Controls.Add(this.label1);
            this.PanelTab.Controls.Add(this.guna2txtSearch);
            this.PanelTab.Controls.Add(this.btnHistory);
            this.PanelTab.Controls.Add(this.btnLogin);
            this.PanelTab.Controls.Add(this.btnSignIn);
            this.PanelTab.Controls.Add(this.Menu);
            this.PanelTab.Controls.Add(this.guna2btnClose);
            this.PanelTab.Controls.Add(this.picAvatar);
            this.PanelTab.Controls.Add(this.lblUsername);
            this.PanelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTab.Location = new System.Drawing.Point(0, 0);
            this.PanelTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTab.Name = "PanelTab";
            this.PanelTab.Size = new System.Drawing.Size(1053, 50);
            this.PanelTab.TabIndex = 3;
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
            this.guna2btnMinimizeToTray.Location = new System.Drawing.Point(940, -4);
            this.guna2btnMinimizeToTray.Name = "guna2btnMinimizeToTray";
            this.guna2btnMinimizeToTray.Size = new System.Drawing.Size(56, 54);
            this.guna2btnMinimizeToTray.TabIndex = 31;
            this.guna2btnMinimizeToTray.Text = "–";
            this.guna2btnMinimizeToTray.Click += new System.EventHandler(this.guna2btnMinimizeToTray_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "WaveSync";
            // 
            // guna2txtSearch
            // 
            this.guna2txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.guna2txtSearch.BorderRadius = 20;
            this.guna2txtSearch.BorderThickness = 0;
            this.guna2txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtSearch.DefaultText = "";
            this.guna2txtSearch.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtSearch.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2txtSearch.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2txtSearch.ForeColor = System.Drawing.Color.Black;
            this.guna2txtSearch.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2txtSearch.Location = new System.Drawing.Point(194, 8);
            this.guna2txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2txtSearch.Name = "guna2txtSearch";
            this.guna2txtSearch.PlaceholderText = "";
            this.guna2txtSearch.SelectedText = "";
            this.guna2txtSearch.Size = new System.Drawing.Size(212, 33);
            this.guna2txtSearch.TabIndex = 4;
            this.guna2txtSearch.TextChanged += new System.EventHandler(this.guna2txtSearch_TextChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(666, 7);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(84, 37);
            this.btnHistory.TabIndex = 26;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Visible = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(560, 5);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(454, 5);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 40);
            this.btnSignIn.TabIndex = 20;
            this.btnSignIn.Text = "Sign Up";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = global::MusicPlayer.Properties.Resources.menu;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Menu.Location = new System.Drawing.Point(6, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(55, 43);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Menu.TabIndex = 5;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
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
            this.guna2btnClose.Location = new System.Drawing.Point(999, -4);
            this.guna2btnClose.Name = "guna2btnClose";
            this.guna2btnClose.Size = new System.Drawing.Size(56, 54);
            this.guna2btnClose.TabIndex = 29;
            this.guna2btnClose.Text = "x";
            this.guna2btnClose.Click += new System.EventHandler(this.guna2btnClose_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(864, 3);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(47, 44);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 28;
            this.picAvatar.TabStop = false;
            this.picAvatar.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(756, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 20);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Not logged in";
            // 
            // notifyIconApp
            // 
            this.notifyIconApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApp.Icon")));
            this.notifyIconApp.Text = "WaveSync";
            this.notifyIconApp.Click += new System.EventHandler(this.notifyIconApp_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Location = new System.Drawing.Point(3, 13);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(260, 60);
            this.pnlHome.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-10, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(280, 80);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlAddMusics
            // 
            this.pnlAddMusics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlAddMusics.Controls.Add(this.btnAddMusics);
            this.pnlAddMusics.Location = new System.Drawing.Point(3, 79);
            this.pnlAddMusics.Name = "pnlAddMusics";
            this.pnlAddMusics.Size = new System.Drawing.Size(260, 60);
            this.pnlAddMusics.TabIndex = 8;
            // 
            // btnAddMusics
            // 
            this.btnAddMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAddMusics.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusics.ForeColor = System.Drawing.Color.White;
            this.btnAddMusics.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMusics.Image")));
            this.btnAddMusics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMusics.Location = new System.Drawing.Point(-10, -9);
            this.btnAddMusics.Name = "btnAddMusics";
            this.btnAddMusics.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddMusics.Size = new System.Drawing.Size(280, 80);
            this.btnAddMusics.TabIndex = 6;
            this.btnAddMusics.Text = "          Add Musics";
            this.btnAddMusics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMusics.UseVisualStyleBackColor = false;
            this.btnAddMusics.Click += new System.EventHandler(this.btnAddMusics_Click);
            // 
            // pnlFavor
            // 
            this.pnlFavor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFavor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlFavor.Controls.Add(this.btnFavor);
            this.pnlFavor.Location = new System.Drawing.Point(3, 145);
            this.pnlFavor.Name = "pnlFavor";
            this.pnlFavor.Size = new System.Drawing.Size(260, 60);
            this.pnlFavor.TabIndex = 9;
            // 
            // btnFavor
            // 
            this.btnFavor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnFavor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavor.ForeColor = System.Drawing.Color.White;
            this.btnFavor.Image = ((System.Drawing.Image)(resources.GetObject("btnFavor.Image")));
            this.btnFavor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavor.Location = new System.Drawing.Point(-10, -9);
            this.btnFavor.Name = "btnFavor";
            this.btnFavor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFavor.Size = new System.Drawing.Size(280, 80);
            this.btnFavor.TabIndex = 6;
            this.btnFavor.Text = "          Favorites";
            this.btnFavor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavor.UseVisualStyleBackColor = false;
            this.btnFavor.Click += new System.EventHandler(this.btnFavor_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(260, 60);
            this.pnlSettings.TabIndex = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-10, -9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(280, 80);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "          Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.SideBar.Controls.Add(this.pnlHome);
            this.SideBar.Controls.Add(this.pnlAddMusics);
            this.SideBar.Controls.Add(this.pnlFavor);
            this.SideBar.Controls.Add(this.SettingsContainer);
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 50);
            this.SideBar.Margin = new System.Windows.Forms.Padding(0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.SideBar.Size = new System.Drawing.Size(65, 542);
            this.SideBar.TabIndex = 11;
            this.SideBar.WrapContents = false;
            // 
            // SettingsContainer
            // 
            this.SettingsContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.SettingsContainer.Controls.Add(this.pnlSettings);
            this.SettingsContainer.Controls.Add(this.pnlUserInfo);
            this.SettingsContainer.Controls.Add(this.pnlLogOut);
            this.SettingsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SettingsContainer.Location = new System.Drawing.Point(3, 211);
            this.SettingsContainer.Name = "SettingsContainer";
            this.SettingsContainer.Size = new System.Drawing.Size(260, 60);
            this.SettingsContainer.TabIndex = 12;
            this.SettingsContainer.WrapContents = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlUserInfo.Controls.Add(this.btnUserInfo);
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 60);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(260, 60);
            this.pnlUserInfo.TabIndex = 11;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.Location = new System.Drawing.Point(-10, -9);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUserInfo.Size = new System.Drawing.Size(280, 80);
            this.btnUserInfo.TabIndex = 6;
            this.btnUserInfo.Text = "          User Info";
            this.btnUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // pnlLogOut
            // 
            this.pnlLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnlLogOut.Controls.Add(this.LogOutbtn);
            this.pnlLogOut.Location = new System.Drawing.Point(0, 120);
            this.pnlLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(260, 60);
            this.pnlLogOut.TabIndex = 12;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LogOutbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbtn.ForeColor = System.Drawing.Color.White;
            this.LogOutbtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutbtn.Image")));
            this.LogOutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutbtn.Location = new System.Drawing.Point(-10, -9);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LogOutbtn.Size = new System.Drawing.Size(280, 80);
            this.LogOutbtn.TabIndex = 6;
            this.LogOutbtn.Text = "          Log Out";
            this.LogOutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // settingsTransitions
            // 
            this.settingsTransitions.Interval = 25;
            this.settingsTransitions.Tick += new System.EventHandler(this.settingsTransitions_Tick);
            // 
            // SideBarTransitions
            // 
            this.SideBarTransitions.Interval = 25;
            this.SideBarTransitions.Tick += new System.EventHandler(this.SideBarTransitions_Tick);
            // 
            // textScrollTimer
            // 
            this.textScrollTimer.Enabled = true;
            this.textScrollTimer.Interval = 200;
            this.textScrollTimer.Tick += new System.EventHandler(this.textScrollTimer_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // roundedPanelMain
            // 
            this.roundedPanelMain.BackColor = System.Drawing.Color.Silver;
            this.roundedPanelMain.BorderRadius = 19;
            this.roundedPanelMain.Controls.Add(this.PanelContent);
            this.roundedPanelMain.Location = new System.Drawing.Point(83, 67);
            this.roundedPanelMain.Name = "roundedPanelMain";
            this.roundedPanelMain.Size = new System.Drawing.Size(954, 504);
            this.roundedPanelMain.TabIndex = 0;
            // 
            // PanelContent
            // 
            this.PanelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContent.Controls.Add(this.flowSongs);
            this.PanelContent.Location = new System.Drawing.Point(3, 3);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(948, 498);
            this.PanelContent.TabIndex = 4;
            // 
            // flowSongs
            // 
            this.flowSongs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowSongs.AutoScroll = true;
            this.flowSongs.BackColor = System.Drawing.Color.Silver;
            this.flowSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSongs.Location = new System.Drawing.Point(16, 18);
            this.flowSongs.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flowSongs.Name = "flowSongs";
            this.flowSongs.Size = new System.Drawing.Size(917, 460);
            this.flowSongs.TabIndex = 0;
            this.flowSongs.WrapContents = false;
            // 
            // MainFormUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1053, 701);
            this.Controls.Add(this.PanelPlayer);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.roundedPanelMain);
            this.Controls.Add(this.PanelTab);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaveSync";
            this.Load += new System.EventHandler(this.MainFormUI_Load);
            this.PanelPlayer.ResumeLayout(false);
            this.PanelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.PanelTab.ResumeLayout(false);
            this.PanelTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlAddMusics.ResumeLayout(false);
            this.pnlFavor.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SettingsContainer.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlLogOut.ResumeLayout(false);
            this.roundedPanelMain.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelPlayer;
        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.FlowLayoutPanel flowSongs;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.Label lblNowPlayingArtist;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.NotifyIcon notifyIconApp;
        private System.Windows.Forms.PictureBox picAvatar;
        private Resources.RoundedPanel roundedPanelMain;
        private System.Windows.Forms.Panel PanelContent;
        private Guna.UI2.WinForms.Guna2Button guna2btnClose;
        private System.Windows.Forms.PictureBox Menu;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlAddMusics;
        private System.Windows.Forms.Button btnAddMusics;
        private System.Windows.Forms.Panel pnlFavor;
        private System.Windows.Forms.Button btnFavor;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.FlowLayoutPanel SettingsContainer;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Timer settingsTransitions;
        private System.Windows.Forms.Timer SideBarTransitions;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2btnMinimizeToTray;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBarVolume;
        private System.Windows.Forms.Timer textScrollTimer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

