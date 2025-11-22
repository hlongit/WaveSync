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
using System.Diagnostics;
namespace MusicPlayer {
    public partial class MainForm : Form {
        // Current playing song
        private Song currentSong;
        public MainForm() {
            InitializeComponent();
        }

        // All songs loaded from database
        private List<Song> allSongs = new List<Song>();

        // Index of currently playing song in the list (-1 = none)
        private int currentIndex = -1;


        // Opens the "Add Music" form when button clicked
        private void AddMusicBtn_Click(object sender, EventArgs e) {
            Form AddMusic = new Forms.AddMusicForm();
            AddMusic.ShowDialog(); // user must close it before continuing
            // refresh song list after adding
            LoadSongs();
        }

        private void MainForm_Load(object sender, EventArgs e) {    
            LoadSongs();
            volumeBar.Value = 70;
            AudioEngine.SetVolume(0.7f);

            // Timer update for seek bar and time
            AudioEngine.PositionChanged += (current, total) =>
            {
                // If form is disposed, do nothing
                if (this.IsDisposed) return;

                // Must use Invoke() because this event comes from another thread
                // Update seek bar and time label using a timer, but only if user is not dragging the seek bar
                // For PositionChanged event, check AudioEngine.cs.
                this.Invoke((MethodInvoker)delegate
                {
                    seekBar.Maximum = (int)total.TotalSeconds;
                    seekBar.Value = Math.Min(seekBar.Maximum, (int)current.TotalSeconds);
                    lblTime.Text = $"{current:mm\\:ss} / {total:mm\\:ss}";
                });
            };
            
            //If user click play on a song
            AudioEngine.PlaybackStarted += () =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    btnPlayPause.Text = "Pause";   // Instantly show "Pause" when song starts
                    seekBar.Value = 0;             // Reset seek bar
                    lblTime.Text = "00:00 / 00:00";
                });
            };

            //If user click stop or song ends
            AudioEngine.PlaybackStopped += () =>
            {
                //Another thread, use Invoke
                this.Invoke((MethodInvoker)delegate
                {
                    btnPlayPause.Text = "Play";
                    // DO NOT reset title and cover here!
                    // Only reset when user actually selects a new song or none
                });
            };
        }
        // Load songs from database and create SongCards
        private void LoadSongs() 
        {
            // Clear existing card list.
            flowSongs.Controls.Clear();

            // Load songs from database, check DatabaseHelper.cs
            allSongs = DatabaseHelper.GetAllSongs();


            foreach (var song in allSongs) {
                var card = new SongCard();
                //Check songcard.cs for structure/name of control.
                card.lblTitle.Text = song.Title;
                card.lblArtist.Text = song.Artist;
                    
                string coverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);
                if (File.Exists(coverPath))
                    card.picCover.Image = Image.FromFile(coverPath);
                // Store the song object in the Tag property for later use.
                card.Tag = song;

                //When user clicks the card, play the song of that card.
                // Maybe change it to default Click event in SongCard.cs later.
                card.Click += (s, e) => {// 5. When song ends → tell MainForm
                    currentIndex = allSongs.IndexOf(song);
                    PlaySong(song);
                };

                flowSongs.Controls.Add(card);
            }
        }

        private void PlaySong(Song song) {
            currentSong = song;

            // Get full paths
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.FilePath);
            string coverFull = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);

            // Update lblSongInfo and picCover when a new song is played
            lblSongInfo.Text = $"{song.Title} - {song.Artist}";
            if (File.Exists(coverFull))
                picCover.Image = Image.FromFile(coverFull);
            else
                picCover.Image = null;

            AudioEngine.PlaySong(fullPath);
            btnPlayPause.Text = "Pause";
        }
        // Play/Pause button click
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
        // Volume bar scroll
        private void volumeBar_Scroll(object sender, EventArgs e) {
            AudioEngine.SetVolume(volumeBar.Value / 100f);
        }

        // Allow user to drag seek bar
        private void seekBar_MouseDown(object sender, MouseEventArgs e) {
            seekBar.Tag = "dragging";  // Mark that user is dragging
        }
        private void seekBar_MouseUp(object sender, MouseEventArgs e) {
            if (seekBar.Tag is "dragging") {
                AudioEngine.Seek(seekBar.Value);  // Jump to new position
                seekBar.Tag = null;
            }
        }


        // Next/Previous  button click
        private void btnNext_Click(object sender, EventArgs e) {
            if (allSongs.Count == 0) return;
            currentIndex = (currentIndex + 1) % allSongs.Count;
            PlaySong(allSongs[currentIndex]);
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            if (allSongs.Count == 0) return;
            currentIndex = (currentIndex - 1 + allSongs.Count) % allSongs.Count;
            PlaySong(allSongs[currentIndex]);
        }

        private void btnViewSongListInfo_Click(object sender, EventArgs e) {
            Form ListSongInfos = new Data.ListSongInfo();
            ListSongInfos.ShowDialog(); 
            LoadSongs();
        }

        private void btnUserListInfo_Click(object sender, EventArgs e) {
            Form ListUserInfos = new Data.ListUserInfo();
            ListUserInfos.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Forms.LoginForm login = new Forms.LoginForm();
            var result = login.ShowDialog();
            string userName = login.UserName;
            if (result == DialogResult.OK)
            {
                label1.Text = userName;
                btnLogin.Visible = false;
            }
        }
        //End.    
    }
}