using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicPlayer {
    public partial class SongCard : UserControl {
        private Timer marqueeTimer;
        private string originalTitle;
        private bool isAnimating = false;
        public SongCard() {
            InitializeComponent();

            /*
            //forward clicks from children to the card
            picCover.Click += (s, e) => { this.OnClick(e); };
            lblTitle.Click += (s, e) => { this.OnClick(e); };
            lblArtist.Click += (s, e) => { this.OnClick(e); };
            */

            //ensure fav button is always on top
            btnFav.BringToFront();

            // Set up marquee effect for long titles
            marqueeTimer = new Timer();
            marqueeTimer.Interval = 200; // Speed of scrolling (lower is faster)
            marqueeTimer.Tick += MarqueeTimer_Tick;

            // 3. Bind Hover Events to EVERYTHING
            // We need to detect hover on the Card AND its children (Labels, PictureBox)
            this.MouseEnter += Card_MouseEnter;
            this.MouseLeave += Card_MouseLeave;

            // Helper to bind events to children
            foreach (Control c in this.Controls) {
                if (c is Button) continue; // Don't bind to the fav button (it has its own click)
                c.MouseEnter += Card_MouseEnter;
                c.MouseLeave += Card_MouseLeave;

            // forward clicks to the main card (so clicking the image plays the song)
            c.Click += (s, e) => this.InvokeOnClick(this, EventArgs.Empty);
            }
        }

        //animation for long titles
        private void MarqueeTimer_Tick(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(lblTitle.Text)) return;

            // Shift text: "Hello" -> "elloH"
            string text = lblTitle.Text;
            lblTitle.Text = text.Substring(1) + text[0];
        }
        private void Card_MouseEnter(object sender, EventArgs e) {
            // Highlight color
            this.BackColor = Color.FromArgb(60, 60, 60);

            // Only start scrolling if text is too long for the label width
            // (We check PreferredWidth vs Width)
            if (lblTitle.PreferredWidth > lblTitle.Width && !isAnimating) {
                originalTitle = lblTitle.Text;
                // Add some spaces for smoother loop
                lblTitle.Text = originalTitle + "     ";
                isAnimating = true;
                marqueeTimer.Start();
            }
        }
        private void Card_MouseLeave(object sender, EventArgs e) {
            // Check if mouse is arguably still inside the card's bounds
            // (This prevents flickering when moving between child controls)
            if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                return;

            // Reset Color
            this.BackColor = Color.FromArgb(40, 40, 40); // Default color

            // Stop Animation
            marqueeTimer.Stop();
            if (isAnimating) {
                lblTitle.Text = originalTitle;
                isAnimating = false;
            }
        }

    }
}
