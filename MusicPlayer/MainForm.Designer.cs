namespace MusicPlayer {
    partial class MainForm {
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
            this.AddMusicBtn = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.SeekLabel = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.flowSongs = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMusicBtn
            // 
            this.AddMusicBtn.Location = new System.Drawing.Point(39, 24);
            this.AddMusicBtn.Name = "AddMusicBtn";
            this.AddMusicBtn.Size = new System.Drawing.Size(173, 49);
            this.AddMusicBtn.TabIndex = 0;
            this.AddMusicBtn.Text = "Add Music";
            this.AddMusicBtn.UseVisualStyleBackColor = true;
            this.AddMusicBtn.Click += new System.EventHandler(this.AddMusicBtn_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(282, 326);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(190, 56);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(507, 326);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(190, 56);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(71, 326);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(190, 56);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // seekBar
            // 
            this.seekBar.Location = new System.Drawing.Point(211, 249);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(221, 56);
            this.seekBar.TabIndex = 4;
            this.seekBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseDown);
            this.seekBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.seekBar_MouseUp);
            // 
            // SeekLabel
            // 
            this.SeekLabel.AutoSize = true;
            this.SeekLabel.Location = new System.Drawing.Point(222, 227);
            this.SeekLabel.Name = "SeekLabel";
            this.SeekLabel.Size = new System.Drawing.Size(39, 16);
            this.SeekLabel.TabIndex = 5;
            this.SeekLabel.Text = "Seek";
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(476, 249);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(221, 56);
            this.volumeBar.TabIndex = 6;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(485, 227);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(53, 16);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "Volume";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.Location = new System.Drawing.Point(220, 179);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(172, 25);
            this.lblSongTitle.TabIndex = 8;
            this.lblSongTitle.Text = "Song Tittle  - Artist";
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(225, 414);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(259, 232);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 9;
            this.picCover.TabStop = false;
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.AutoSize = true;
            this.lblSongInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.Location = new System.Drawing.Point(388, 132);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(131, 25);
            this.lblSongInfo.TabIndex = 10;
            this.lblSongInfo.Text = "Select a song";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(563, 179);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 25);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // flowSongs
            // 
            this.flowSongs.AutoScroll = true;
            this.flowSongs.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowSongs.Location = new System.Drawing.Point(747, 0);
            this.flowSongs.Name = "flowSongs";
            this.flowSongs.Size = new System.Drawing.Size(446, 740);
            this.flowSongs.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 740);
            this.Controls.Add(this.flowSongs);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSongInfo);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.SeekLabel);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.AddMusicBtn);
            this.Name = "MainForm";
            this.Text = "WaveSync";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMusicBtn;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Label SeekLabel;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.FlowLayoutPanel flowSongs;
    }
}

