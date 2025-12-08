using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer.Controls
{
    public partial class SongControls : UserControl
    {
        public Song SongData { get; private set; }

        public SongControls(Song song)
        {
            InitializeComponent();

            SongData = song;

            lblTitle.Text = song.Title;
            lblArtist.Text = song.Artist;
            lblAlbum.Text = song.Album;

            // Event click
            this.Click += SongControls_Click;
            foreach (Control c in this.Controls)
                c.Click += SongControls_Click;
        }

        private void SongControls_Click(object sender, EventArgs e)
        {
            OnSongClick?.Invoke(this, SongData);
        }

        public static event EventHandler<Song> OnSongClick;
    }
}
