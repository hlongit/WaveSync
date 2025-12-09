using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer.Controls;
using MusicPlayer.Data;
using NAudio.Wave;
// using static MusicPlayer.Forms.LoginForm; // Uncomment if needed, but LoginSession.UserID works better

namespace MusicPlayer {
    public partial class MainFormUI : Form {

        // --- 1. ORIGINAL FIELDS ---
        private Song currentSong;
        private AudioFileReader audioFile;
        private WaveOutEvent audioPlayer;
        private List<Song> allSongs = new List<Song>();
        private int currentIndex = -1;
        private bool loopCurrentSong = false;
        private Random rng = new Random();
        private MusicPlayer.Data.ListSongs listSongsView; // Assuming this is a UserControl for listing songs

        public MainFormUI() {
            InitializeComponent();

            // Wire up the events manually if Designer didn't catch them
            SongControls.OnSongClick += SongControls_OnClick;
        }

        // --- 2. MAIN FORM LOAD LOGIC ---
        private void MainFormUI_Load(object sender, EventArgs e) {
            // Get data from DB
            allSongs = DatabaseHelper.GetAllSongs();
            LoadSongs(allSongs);

            volumeBar.Value = 70;
            AudioEngine.SetVolume(0.7f);

            // Register Controls with AudioEngine
            AudioEngine.RegisterControls(
                this,
                seekBar,
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

        // --- 3. UNIFIED LOAD SONGS FUNCTION ---
        private void LoadSongs(List<Song> songs) {
            flowSongs.Controls.Clear();

            foreach (var song in songs) {
                var card = new SongCard();

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

                flowSongs.Controls.Add(card);
            }
        }

        // --- 4. PLAYBACK LOGIC ---
        private void PlaySong(Song song) {
            currentSong = song;

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.FilePath);
            string coverFull = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);

            // Using the renamed label (was lblNowPlayingTitle)
            lblSongInfo.Text = $"{song.Title} - {song.Artist}";

            if (File.Exists(coverFull))
                picCover.Image = Image.FromFile(coverFull);
            else
                picCover.Image = null;

            AudioEngine.PlaySong(fullPath);
            btnPlayPause.Text = "Pause"; // Or change to Pause Icon

            // Handle History (assuming LoginSession exists)
            int currentUserId = MusicPlayer.Forms.LoginForm.LoginSession.UserID;
            if (DatabaseHelper.UserExists(currentUserId)) {
                DatabaseHelper.AddToPlayHistory(currentUserId, song.SongId);
            }
        }

        private void PlayNextSong() {
            if (allSongs.Count == 0) return;
            currentIndex = (currentIndex + 1) % allSongs.Count;
            PlaySong(allSongs[currentIndex]);
        }

        // --- 5. EVENT HANDLERS (Connect these in Designer if needed) ---

        private void btnPlayPause_Click(object sender, EventArgs e) {
            if (AudioEngine.IsPlaying) {
                AudioEngine.Pause();
                btnPlayPause.Text = "Play";
            }
            else {
                AudioEngine.Resume();
                btnPlayPause.Text = "Pause";
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

        private void volumeBar_Scroll(object sender, EventArgs e) {
            AudioEngine.SetVolume(volumeBar.Value / 100f);
        }

        private void seekBar_MouseDown(object sender, MouseEventArgs e) {
            seekBar.Tag = "dragging";
        }

        private void seekBar_MouseUp(object sender, MouseEventArgs e) {
            if (seekBar.Tag is "dragging") {
                AudioEngine.Seek(seekBar.Value);
                seekBar.Tag = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = allSongs.Where(s =>
                s.Title.ToLower().Contains(keyword) ||
                s.Artist.ToLower().Contains(keyword) ||
                s.Album.ToLower().Contains(keyword) ||
                s.FilePath.ToLower().Contains(keyword)
            ).ToList();
            LoadSongs(filtered);
        }

        private void btnShuffle_Click(object sender, EventArgs e) {
            ShuffleList(allSongs);
            LoadSongs(allSongs);
        }

        private void btnLoop_Click(object sender, EventArgs e) {
            loopCurrentSong = !loopCurrentSong;
            btnLoop.Text = loopCurrentSong ? "Loop: ON" : "Loop: OFF";
        }

        // --- 6. UTILITY METHODS ---
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

        // --- 7. BUTTONS FOR DB / ADMIN / LOGIN ---
        private void AddMusicBtn_Click(object sender, EventArgs e) {
            Form AddMusic = new Forms.AddMusicForm();
            AddMusic.ShowDialog();
            allSongs = DatabaseHelper.GetAllSongs();
            LoadSongs(allSongs);
        }

        private void btnViewSongListInfo_Click(object sender, EventArgs e) {
            /*Form ListSongInfos = new Data.ListSongInfo();
            ListSongInfos.ShowDialog();
            allSongs = DatabaseHelper.GetAllSongs();
            LoadSongs(allSongs);*/

            // 1. Setup UI for "Database View"
            flowSongs.Visible = false; // Hide the card list

            // 2. Initialize the UserControl if it doesn't exist
            if (listSongsView == null) {
                listSongsView = new MusicPlayer.Data.ListSongs();
                listSongsView.Dock = DockStyle.Fill;
                PanelContent.Controls.Add(listSongsView);
            }

            // 3. Refresh Data & Show
            listSongsView.RefreshData(); // Fetch latest changes
            listSongsView.Visible = true;
            listSongsView.BringToFront();
        }

        private void btnUserListInfo_Click(object sender, EventArgs e) {
            Form ListUserInfos = new Data.ListUserInfo();
            ListUserInfos.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Forms.LoginForm login = new Forms.LoginForm();
            var result = login.ShowDialog();
            string userName = login.UserName;
            if (result == DialogResult.OK) {
                lblUsername.Text = "User: " + userName;
                lblUsername.Visible = true;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                AddMusicBtn.Visible = true;
                btnHistory.Visible = true;
                btnSignIn.Visible = false;
                if (userName == "Admin1") btnUserListInfo.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                lblUsername.Text = null;
                lblUsername.Visible = false;
                btnLogin.Visible = true;
                btnLogout.Visible = false;
                AddMusicBtn.Visible = false;
                btnHistory.Visible = false;
                btnSignIn.Visible = true;
                btnUserListInfo.Visible = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e) {
            Forms.SignInForm signin = new Forms.SignInForm();
            signin.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e) {
            var f = new MusicPlayer.Data.PlayHistoryForm();
            f.ShowDialog();
        }

        // --- 8. PLACEHOLDERS FOR NEW UI ELEMENTS (Handling Unknowns) ---
        private void btnHome_Click(object sender, EventArgs e) {
            listSongsView.Visible = false;
            flowSongs.Visible = true;
            flowSongs.BringToFront();
        }

        private void btnSongs_Click(object sender, EventArgs e) {
            // "Button that cannot click" - Implement later
        }

        private void btnSetting_Click(object sender, EventArgs e) {
            // "Button that cannot click" - Implement later
        }

        private void btnVolume_Click(object sender, EventArgs e) {
            // Logic for Mute could go here
        }

        private void MainFormUI_Resize(object sender, EventArgs e) {
            Invalidate();
        }
    }
}