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
namespace MusicPlayer {
    public partial class MainForm : Form {
        private Song currentSong;
        public MainForm() {
            InitializeComponent();
        }
        private List<Song> allSongs = new List<Song>();
        private int currentIndex = -1;
        private void AddMusicBtn_Click(object sender, EventArgs e) {
            Form AddMusic = new Forms.AddMusicForm();
            AddMusic.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadSongs();
            volumeBar.Value = 70;
            AudioEngine.SetVolume(0.7f);

            // Timer update for seek bar and time
            AudioEngine.PositionChanged += (current, total) =>
            {
                if (this.IsDisposed) return;

                this.Invoke((MethodInvoker)delegate
                {
                    seekBar.Maximum = (int)total.TotalSeconds;
                    seekBar.Value = Math.Min(seekBar.Maximum, (int)current.TotalSeconds);
                    lblTime.Text = $"{current:mm\\:ss} / {total:mm\\:ss}";
                });
            };

            AudioEngine.PlaybackStopped += () =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    btnPlayPause.Text = "Play";
                    // DO NOT reset title and cover here!
                    // Only reset when user actually selects a new song or none
                });
            };
        }
        private void LoadSongs() 
        {
            flowSongs.Controls.Clear();
            allSongs = DatabaseHelper.GetAllSongs();

            foreach (var song in allSongs) {
                var card = new SongCard();
                card.lblTitle.Text = song.Title;
                card.lblArtist.Text = song.Artist;

                string coverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);
                if (File.Exists(coverPath))
                    card.picCover.Image = Image.FromFile(coverPath);

                card.Tag = song;

                // ONE LINE — entire card clickable!
                card.Click += (s, e) =>
                {
                    currentIndex = allSongs.IndexOf(song);
                    PlaySong(song);
                };

                flowSongs.Controls.Add(card);
            }
        }

        private void PlaySong(Song song) {
            currentSong = song;

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.FilePath);
            string coverFull = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, song.CoverPath);

            // Always update UI
            lblSongInfo.Text = $"{song.Title} - {song.Artist}";
            if (File.Exists(coverFull))
                picCover.Image = Image.FromFile(coverFull);
            else
                picCover.Image = null;

            AudioEngine.PlaySong(fullPath);
            btnPlayPause.Text = "Pause";
        }
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
    }

}