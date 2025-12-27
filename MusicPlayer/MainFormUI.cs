using MusicPlayer.Controls;
using MusicPlayer.Core;
using MusicPlayer.Data;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
// using static MusicPlayer.Forms.LoginForm; // Uncomment if needed, but LoginSession.UserID works better

namespace MusicPlayer {
    public partial class MainFormUI : Form {
        // --- DLL IMPORTS FOR DRAGGING THE WINDOW ---
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // --- ORIGINAL FIELDS ---
        private Song currentSong;
        //private AudioFileReader audioFile;
        //private WaveOutEvent audioPlayer;
        private List<Song> allSongs = new List<Song>();
        private int currentIndex = -1;
        private bool loopCurrentSong = false;
        private Random rng = new Random();
        private MusicPlayer.Data.ListSongs listSongsView; // Assuming this is a UserControl for listing songs
        private UserInfoControl UserInfo; // User Info Control
        public MainFormUI() {
            InitializeComponent();

            // Wire up the events manually if Designer didn't catch them
            SongControls.OnSongClick += SongControls_OnClick;

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED (Khử flickering)
                return cp;
            }
        }
        // --- MAIN FORM LOAD LOGIC ---
        private void MainFormUI_Load(object sender, EventArgs e) {
            // sidebar INIT
            SideBar.Width = 65;
            sidebarExpanded = true;

            // settings INIT
            pnlSettings.Height = 60;
            settingsExpanded = false;

            // Get data from DB
            allSongs = DatabaseHelper.GetAllSongs();
            LoadSongs(allSongs);
            guna2TrackBarVolume.Minimum = 0;
            guna2TrackBarVolume.Maximum = 100;
            guna2TrackBarVolume.Value = 70;
            AudioEngine.SetVolume(0.7f);

            // Register Controls with AudioEngine
            AudioEngine.RegisterControls(
                this,
                guna2TrackBar,  // Make sure you added this TrackBar!
                lblTime,        // Make sure you added this Label!
                btnPlayPause,
                () => {
                    if (loopCurrentSong && currentSong != null)
                        PlaySong(currentSong);
                    else
                        PlayNextSong();
                }
            );
        }
        // --- LOAD SONG (CARDS) FUNCTION ---
        private void LoadSongs(List<Song> songs) {
            flowSongs.Controls.Clear();
            int currentUserId = CurrentUser.UserID; // Get logged in user

            foreach (var song in songs) {
                var card = new SongCard();

                //generate card details

                card.lblTitle.Text = song.Title;
                card.lblArtist.Text = song.Artist;

                string coverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);
                if (File.Exists(coverPath))
                    card.picCover.Image = Image.FromFile(coverPath);
                else
                    card.picCover.Image = null;

                card.Tag = song;

                card.Click += (s, e) => {
                    currentIndex = allSongs.IndexOf(song);
                    PlaySong(song);
                };

                // --- FAVORITE LOGIC ---
                if (currentUserId > 0) { // Only if logged in
                                         // 1. Set Initial State (Color)
                    bool isFav = DatabaseHelper.IsFavorite(currentUserId, song.SongId);
                    card.btnFav.ForeColor = isFav ? Color.Red : Color.Gray;

                    // 2. Click Event
                    card.btnFav.Click += (s, e) => {
                        bool currentlyFav = (card.btnFav.ForeColor == Color.Red);

                        if (currentlyFav) {
                            DatabaseHelper.RemoveFromFavorites(currentUserId, song.SongId);
                            card.btnFav.ForeColor = Color.Gray;
                        }
                        else {
                            DatabaseHelper.AddToFavorites(currentUserId, song.SongId);
                            card.btnFav.ForeColor = Color.Red;
                        }
                    };
                }
                else {
                    // Hide button if not logged in
                    card.btnFav.Visible = false;
                }

                flowSongs.Controls.Add(card);
            }
        }
        // --- PLAYBACK LOGIC ---
        private void PlaySong(Song song) {
            currentSong = song;

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.FilePath);
            string coverFull = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);

            lblSongInfo.Text = song.Title;           // Top label (Title)
            lblNowPlayingArtist.Text = song.Artist;  // Bottom label (Artist)

            SetupMarquee(lblSongInfo, song.Title);
            SetupMarquee(lblNowPlayingArtist, song.Artist);

            if (File.Exists(coverFull))
                picCover.Image = Image.FromFile(coverFull);
            else
                picCover.Image = null;

            AudioEngine.PlaySong(fullPath);

            // Handle History (assuming LoginSession exists)
            int currentUserId = CurrentUser.UserID;
            if (DatabaseHelper.UserExists(currentUserId)) {
                DatabaseHelper.AddToPlayHistory(currentUserId, song.SongId);
            }
        }
        // Helper function to measure text and setup scrolling, used for longer song names and artists name of currently playing song
        private void SetupMarquee(Label lbl, string text) {
            // 1. Measure how wide the text is
            Size textSize = TextRenderer.MeasureText(text, lbl.Font);

            // 2. Check against the Label's FIXED width
            if (textSize.Width > lbl.Width) {
                // Text is too long! Enable scrolling.
                // Add 5 spaces so the end doesn't stick to the start
                lbl.Text = text + "     ";

                if (lbl == lblSongInfo) shouldScrollTitle = true;
                if (lbl == lblNowPlayingArtist) shouldScrollArtist = true;
            }
            else {
                // Text fits fine. No scrolling needed.
                lbl.Text = text;

                if (lbl == lblSongInfo) shouldScrollTitle = false;
                if (lbl == lblNowPlayingArtist) shouldScrollArtist = false;
            }
        }
        private void PlayNextSong() {
            if (allSongs.Count == 0) return;
            currentIndex = (currentIndex + 1) % allSongs.Count;
            PlaySong(allSongs[currentIndex]);
        }
        // --- EVENT HANDLERS (Connect these in Designer if needed) ---
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (AudioEngine.IsPlaying)
                AudioEngine.Pause();
            else
            {
                if (currentSong != null)
                    AudioEngine.Resume();
                else
                    PlayNextSong();
            }
        }
        private void btnNext_Click(object sender, EventArgs e) {
            PlayNextSong();
        }
        private void btnPrevious_Click(object sender, EventArgs e) {
            if (allSongs.Count == 0) return;
            currentIndex = (currentIndex - 1 + allSongs.Count) % allSongs.Count;
            PlaySong(allSongs[currentIndex]);
        }
        private bool isShuffleOn = false;
        private bool isLoopOn = false;
        private void btnShuffle_Click(object sender, EventArgs e) {
            ShuffleList(allSongs);
            LoadSongs(allSongs);
            isShuffleOn = !isShuffleOn;

            btnShuffle.BackColor = isShuffleOn
                ? Color.Silver
                : Color.Transparent;
        }
        private void btnLoop_Click(object sender, EventArgs e) {
            loopCurrentSong = !loopCurrentSong;
            isLoopOn = !isLoopOn;

            btnLoop.BackColor = isLoopOn
                ? Color.Silver
                : Color.Transparent;
        }
        // --- UTILITY METHODS ---
        private void ShuffleList(List<Song> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                var temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
        }
        private void SongControls_OnClick(object sender, Song song) {
            PlaySong(song);
        }
        // --- BUTTONS FOR DB / ADMIN / LOGIN ---

        //private void btnViewSongListInfo_Click(object sender, EventArgs e) {
        //    /*Form ListSongInfos = new Data.ListSongInfo();
        //    ListSongInfos.ShowDialog();
        //    allSongs = DatabaseHelper.GetAllSongs();
        //    LoadSongs(allSongs);*/

        //    // 1. Setup UI for "Database View"
        //    flowSongs.Visible = false; // Hide the card list

        //    // 2. Initialize the UserControl if it doesn't exist
        //    if (listSongsView == null) {
        //        listSongsView = new MusicPlayer.Data.ListSongs();
        //        listSongsView.Dock = DockStyle.Fill;
        //        PanelContent.Controls.Add(listSongsView);
        //    }

        //    // 3. Refresh Data & Show
        //    listSongsView.RefreshData(); // Fetch latest changes
        //    listSongsView.Visible = true;
        //    listSongsView.BringToFront();
        //}
        private void btnUserListInfo_Click(object sender, EventArgs e) {
            Form ListUserInfos = new Data.ListUserInfo();
            ListUserInfos.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            Forms.LoginForm login = new Forms.LoginForm();
            var result = login.ShowDialog();
            string userName = login.UserName;
            int userID = login.UserID;
            //string password = login.Password;
            if (result == DialogResult.OK) {
                lblUsername.Text = "User: " + userName;
                btnLogin.Visible = false;
                LogOutbtn.Visible = true;
                btnAddMusics.Visible = true;
                btnHistory.Visible = true;
                btnSignIn.Visible = false;
                btnUserInfo.Visible = true;
                picAvatar.Visible = true;
               // if (userName == "Admin1") btnUserListInfo.Visible = true;
                MusicPlayer.Core.CurrentUser user = new MusicPlayer.Core.CurrentUser();
                user.UpdateUser(userID,userName); 
                DatabaseHelper.LoadAvatar(userID, picAvatar);
            }
            LoadSongs(allSongs); // Refresh to show favorite buttons if needed
        }
        private void btnSignIn_Click(object sender, EventArgs e) {
            Forms.SignUpForm signin = new Forms.SignUpForm();
            signin.ShowDialog();
        }
        private void btnHistory_Click(object sender, EventArgs e) {
            var f = new MusicPlayer.Data.PlayHistoryForm();
            f.ShowDialog();
        }
        private void btnVolume_Click(object sender, EventArgs e) {
            if (guna2TrackBarVolume.Value > 0) {
                guna2TrackBarVolume.Value = 0;
                // change image into volumemute.png
                btnVolume.BackgroundImage = Properties.Resources.volumemute;             
            }
            else {
                guna2TrackBarVolume.Value = 70;
                btnVolume.BackgroundImage = Properties.Resources.volume;
            }
            AudioEngine.SetVolume(guna2TrackBarVolume.Value / 100f);
        }
        // --- ADDITIONAL FEATURES: SEARCH, HOME, FAVORITES, USER INFO, LOG OUT, MINIMIZE TO TRAY, VOLUME, SEEKING, DRAG WINDOW, ANIMATIONS ---
        private void guna2txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = guna2txtSearch.Text.Trim().ToLower();
            var filtered = allSongs.Where(s =>
                s.Title.ToLower().Contains(keyword) ||
                s.Artist.ToLower().Contains(keyword) ||
                s.Album.ToLower().Contains(keyword) ||
                s.FilePath.ToLower().Contains(keyword)
            ).ToList();
            LoadSongs(filtered);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (listSongsView != null) listSongsView.Visible = false;
            if (UserInfo != null) UserInfo.Visible = false;
            lblUsername.Text = "User: " + CurrentUser.Username;
            DatabaseHelper.LoadAvatar(CurrentUser.UserID, picAvatar);
            flowSongs.Visible = true;
            flowSongs.BringToFront();
            LoadSongs(allSongs);
        }
        private void btnAddMusics_Click(object sender, EventArgs e)
        {
            Form AddMusic = new Forms.AddMusicForm();
            AddMusic.ShowDialog();
            allSongs = DatabaseHelper.GetAllSongs();
            LoadSongs(allSongs);
        }
        private void btnFavor_Click(object sender, EventArgs e)
        {
            int userId = CurrentUser.UserID;

            if (userId <= 0)
            {
                MessageBox.Show("Please login to see favorites!");
                return;
            }

            // 1. Switch UI Mode
            flowSongs.Visible = true;
            flowSongs.BringToFront(); // Re-use home layout (it has the flow panel)

            // 2. Load SPECIFIC data
            var favSongs = DatabaseHelper.GetFavoriteSongs(userId);
            LoadSongs(favSongs);
        }
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            flowSongs.Visible = false; // Hide the card list

            // 2. Initialize the UserControl if it doesn't exist
            if (UserInfo == null)
            {
                UserInfo = new UserInfoControl();
                PanelContent.Controls.Add(UserInfo);
            }

            // 3. Refresh Data & Show
            UserInfo.Visible = true;
            UserInfo.BringToFront();
        }
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            // 1. Check if user is actually logged in
            // Assuming 0 or -1 means "Guest" or "Not Logged In"
            if (CurrentUser.UserID <= 0) {
                MessageBox.Show("You haven't logged in yet, so you cannot log out.",
                                "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Stop here
            }

            // 2. Real Logout Logic
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                // Reset Session
                CurrentUser.UserID = -1;
                CurrentUser.Username = "Guest";
                CurrentUser.Password = "";
                CurrentUser.AvatarPath = "";
                // Reset UI (Hide Logout, Show Login)
                LogOutbtn.Visible = false;
                btnLogin.Visible = true;

                btnHistory.Visible = false;
                btnSignIn.Visible = true;
                picAvatar.Visible = false;             
                lblUsername.Text = "Not Logged in";

                UserInfo.LoadUserInfo();

                MessageBox.Show("Logged out successfully.");
            }
        }
        // MINIMIZE TO TRAY LOGIC
        private void guna2btnMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.Hide();                   // Hides the form from the screen AND taskbar
            notifyIconApp.Visible = true;  // Show the icon in the system tray

            // Optional: Show a little popup bubble
            notifyIconApp.ShowBalloonTip(2000, "WaveSync", "Running in background", ToolTipIcon.Info);
        }
        private void notifyIconApp_Click(object sender, EventArgs e) {
            this.Show();                   // Bring form back
            this.WindowState = FormWindowState.Normal; // Ensure it's not minimized
            notifyIconApp.Visible = false; // Hide the tray icon again
        }
        // VOLUME TRACKBAR LOGIC
        private void guna2TrackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            AudioEngine.SetVolume(guna2TrackBarVolume.Value / 100f);
        }
        // TRACKBAR SEEKING LOGIC
        private void guna2TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            guna2TrackBar.Tag = "dragging";
        }
        private void guna2TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (guna2TrackBar.Tag is "dragging")
            {
                AudioEngine.Seek(guna2TrackBar.Value);
                guna2TrackBar.Tag = null;

            }
        }
        // DRAG WINDOW
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        // SIDEBAR AND SETTINGS ANIMATIONS
        bool settingsExpanded = false;
        private void settingsTransitions_Tick(object sender, EventArgs e)
        {
            int minHeight = 60;
            int maxHeight = 190;

            if (!settingsExpanded)
            {
                SettingsContainer.Height += 10;
                if (SettingsContainer.Height >= maxHeight)
                {
                    settingsExpanded = true;
                    SettingsContainer.Height = maxHeight;
                    settingsTransitions.Stop();
                }
            }
            else
            {
                SettingsContainer.Height -= 10;
                if (SettingsContainer.Height <= minHeight)
                {
                    settingsExpanded = false;
                    SettingsContainer.Height = minHeight;
                    settingsTransitions.Stop();
                }
            }
            //this.Invalidate();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsTransitions.Start();
        }
        bool sidebarExpanded = true;
        private void SideBarTransitions_Tick(object sender, EventArgs e)
        {
            int minWidth = 65;
            int maxWidth = 260;

            if (sidebarExpanded)
            {
                SideBar.Width -= 10;
                if (SideBar.Width <= minWidth)
                {
                    sidebarExpanded = false;
                    SideBar.Width = minWidth;
                    SideBarTransitions.Stop();                 

                    pnlHome.Width = SideBar.Width;
                    pnlAddMusics.Width = SideBar.Width;
                    pnlFavor.Width = SideBar.Width;
                    SettingsContainer.Width = SideBar.Width;
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width >= maxWidth)
                {
                    sidebarExpanded = true;
                    SideBar.Width = maxWidth;
                    SideBarTransitions.Stop();

                    pnlHome.Width = SideBar.Width;
                    pnlAddMusics.Width = SideBar.Width;
                    pnlFavor.Width = SideBar.Width;
                    SettingsContainer.Width = SideBar.Width;

                }
            }
            //this.Invalidate();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            SideBarTransitions.Start();
        }
        private void guna2btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2TrackBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
        //Check for longer tittle and artist to in currently playing song, if it is too long for the box, enable scrolling
        private bool shouldScrollTitle = false;
        private bool shouldScrollArtist = false;
        private void textScrollTimer_Tick(object sender, EventArgs e) {
            // 1. Handle Title Scrolling
            if (shouldScrollTitle && !string.IsNullOrEmpty(lblSongInfo.Text)) {
                string current = lblSongInfo.Text;
                // Take everything from index 1 to end, add index 0 at the back
                lblSongInfo.Text = current.Substring(1) + current[0];
            }

            // 2. Handle Artist Scrolling
            if (shouldScrollArtist && !string.IsNullOrEmpty(lblNowPlayingArtist.Text)) {
                string current = lblNowPlayingArtist.Text;
                lblNowPlayingArtist.Text = current.Substring(1) + current[0];
            }
        }
    }
}
