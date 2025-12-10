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
        
        public SongCard() {
            InitializeComponent();

            //forward clicks from children to the card
            picCover.Click += (s, e) => { this.OnClick(e); };
            lblTitle.Click += (s, e) => { this.OnClick(e); };
            lblArtist.Click += (s, e) => { this.OnClick(e); };

            //ensure fav button is always on top
            btnFav.BringToFront();

            // Optional: beautiful hover effect
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(60, 60, 60);
            this.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(40, 40, 40);
        }
    }
}
