namespace Interface.Controls
{
    partial class SongControls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCovers = new System.Windows.Forms.PictureBox();
            this.lblSTitle = new System.Windows.Forms.Label();
            this.lblSArtist = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCovers)).BeginInit();
            this.SuspendLayout();
            // 
            // picCovers
            // 
            this.picCovers.Location = new System.Drawing.Point(73, 68);
            this.picCovers.Name = "picCovers";
            this.picCovers.Size = new System.Drawing.Size(250, 250);
            this.picCovers.TabIndex = 0;
            this.picCovers.TabStop = false;
            // 
            // lblSTitle
            // 
            this.lblSTitle.AutoSize = true;
            this.lblSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTitle.Location = new System.Drawing.Point(373, 118);
            this.lblSTitle.Name = "lblSTitle";
            this.lblSTitle.Size = new System.Drawing.Size(126, 46);
            this.lblSTitle.TabIndex = 1;
            this.lblSTitle.Text = "label1";
            this.lblSTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSArtist
            // 
            this.lblSArtist.AutoSize = true;
            this.lblSArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSArtist.Location = new System.Drawing.Point(377, 235);
            this.lblSArtist.Name = "lblSArtist";
            this.lblSArtist.Size = new System.Drawing.Size(92, 32);
            this.lblSArtist.TabIndex = 2;
            this.lblSArtist.Text = "label1";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPlay.BackgroundImage = global::Interface.Properties.Resources.play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPlay.Location = new System.Drawing.Point(730, 228);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 90);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // SongControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblSArtist);
            this.Controls.Add(this.lblSTitle);
            this.Controls.Add(this.picCovers);
            this.Name = "SongControls";
            this.Size = new System.Drawing.Size(892, 481);
            this.Load += new System.EventHandler(this.SongControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCovers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCovers;
        private System.Windows.Forms.Label lblSTitle;
        private System.Windows.Forms.Label lblSArtist;
        private System.Windows.Forms.Button btnPlay;
    }
}
