namespace MusicPlayer.Forms {
    partial class AddMusicForm {
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CoverPath = new System.Windows.Forms.TextBox();
            this.MusicPathButton = new System.Windows.Forms.Button();
            this.CoverPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bài hát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nghệ sĩ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đường dẫn";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(345, 114);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(183, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(345, 204);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(183, 22);
            this.txtAlbum.TabIndex = 7;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(345, 156);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(183, 22);
            this.txtArtist.TabIndex = 8;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(345, 257);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(183, 22);
            this.txtPath.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đường dẫn ảnh bìa";
            // 
            // CoverPath
            // 
            this.CoverPath.Location = new System.Drawing.Point(345, 297);
            this.CoverPath.Name = "CoverPath";
            this.CoverPath.Size = new System.Drawing.Size(183, 22);
            this.CoverPath.TabIndex = 11;
            // 
            // MusicPathButton
            // 
            this.MusicPathButton.Location = new System.Drawing.Point(534, 254);
            this.MusicPathButton.Name = "MusicPathButton";
            this.MusicPathButton.Size = new System.Drawing.Size(131, 30);
            this.MusicPathButton.TabIndex = 12;
            this.MusicPathButton.Text = "Browse .mp3";
            this.MusicPathButton.UseVisualStyleBackColor = true;
            this.MusicPathButton.Click += new System.EventHandler(this.MusicPathButton_Click);
            // 
            // CoverPathButton
            // 
            this.CoverPathButton.Location = new System.Drawing.Point(534, 289);
            this.CoverPathButton.Name = "CoverPathButton";
            this.CoverPathButton.Size = new System.Drawing.Size(131, 30);
            this.CoverPathButton.TabIndex = 13;
            this.CoverPathButton.Text = "Browse cover";
            this.CoverPathButton.UseVisualStyleBackColor = true;
            this.CoverPathButton.Click += new System.EventHandler(this.CoverPathButton_Click);
            // 
            // AddMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoverPathButton);
            this.Controls.Add(this.MusicPathButton);
            this.Controls.Add(this.CoverPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddMusicForm";
            this.Text = "AddMusicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CoverPath;
        private System.Windows.Forms.Button MusicPathButton;
        private System.Windows.Forms.Button CoverPathButton;
    }
}
