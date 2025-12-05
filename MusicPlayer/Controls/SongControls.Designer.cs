namespace MusicPlayer.Controls
{
    partial class SongControls
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Song Title";
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArtist.Location = new System.Drawing.Point(10, 32);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(200, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlbum.Location = new System.Drawing.Point(220, 22);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(110, 20);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album";
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SongItem
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(340, 60);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
    }
}
