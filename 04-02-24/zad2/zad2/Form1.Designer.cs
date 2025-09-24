namespace zad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            next = new PictureBox();
            prev = new PictureBox();
            pictureBox2 = new PictureBox();
            artist = new Label();
            album = new Label();
            songsNumber = new Label();
            year = new Label();
            downloads = new Label();
            downloadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // next
            // 
            next.Anchor = AnchorStyles.Right;
            next.Image = Properties.Resources.obraz2;
            next.Location = new Point(901, 182);
            next.Name = "next";
            next.Size = new Size(96, 70);
            next.SizeMode = PictureBoxSizeMode.AutoSize;
            next.TabIndex = 6;
            next.TabStop = false;
            next.Click += next_Click;
            // 
            // prev
            // 
            prev.Anchor = AnchorStyles.Left;
            prev.Image = Properties.Resources.obraz3;
            prev.Location = new Point(12, 182);
            prev.Name = "prev";
            prev.Size = new Size(96, 70);
            prev.SizeMode = PictureBoxSizeMode.AutoSize;
            prev.TabIndex = 8;
            prev.TabStop = false;
            prev.Click += prev_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.obraz;
            pictureBox2.Location = new Point(131, 61);
            pictureBox2.Margin = new Padding(3, 3, 50, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // artist
            // 
            artist.AutoSize = true;
            artist.Font = new Font("Segoe UI", 50F);
            artist.ForeColor = Color.White;
            artist.Location = new Point(339, 61);
            artist.Name = "artist";
            artist.Size = new Size(108, 89);
            artist.TabIndex = 9;
            artist.Text = "xd";
            // 
            // album
            // 
            album.AutoSize = true;
            album.Font = new Font("Segoe UI", 30F, FontStyle.Italic);
            album.ForeColor = Color.White;
            album.Location = new Point(339, 150);
            album.Name = "album";
            album.Size = new Size(63, 54);
            album.TabIndex = 10;
            album.Text = "xd";
            // 
            // songsNumber
            // 
            songsNumber.AutoSize = true;
            songsNumber.Font = new Font("Segoe UI", 20F);
            songsNumber.ForeColor = Color.FromArgb(97, 217, 24);
            songsNumber.Location = new Point(339, 204);
            songsNumber.Name = "songsNumber";
            songsNumber.Size = new Size(45, 37);
            songsNumber.TabIndex = 11;
            songsNumber.Text = "xd";
            // 
            // year
            // 
            year.AutoSize = true;
            year.Font = new Font("Segoe UI", 20F);
            year.ForeColor = Color.FromArgb(97, 217, 24);
            year.Location = new Point(516, 204);
            year.Name = "year";
            year.Size = new Size(45, 37);
            year.TabIndex = 12;
            year.Text = "xd";
            // 
            // downloads
            // 
            downloads.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            downloads.AutoSize = true;
            downloads.Font = new Font("Segoe UI", 20F);
            downloads.ForeColor = Color.FromArgb(97, 217, 24);
            downloads.Location = new Point(140, 302);
            downloads.Name = "downloads";
            downloads.Size = new Size(122, 37);
            downloads.TabIndex = 13;
            downloads.Text = "Pobrania";
            // 
            // downloadbtn
            // 
            downloadbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            downloadbtn.BackColor = Color.FromArgb(97, 217, 24);
            downloadbtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            downloadbtn.ForeColor = Color.Black;
            downloadbtn.Location = new Point(266, 292);
            downloadbtn.Name = "downloadbtn";
            downloadbtn.Size = new Size(136, 56);
            downloadbtn.TabIndex = 14;
            downloadbtn.Text = "Pobierz";
            downloadbtn.UseVisualStyleBackColor = false;
            downloadbtn.Click += downloadbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1009, 422);
            Controls.Add(downloadbtn);
            Controls.Add(downloads);
            Controls.Add(year);
            Controls.Add(songsNumber);
            Controls.Add(album);
            Controls.Add(artist);
            Controls.Add(next);
            Controls.Add(prev);
            Controls.Add(pictureBox2);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "MojeDźwięki. Wykonał: 00000000000";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)next).EndInit();
            ((System.ComponentModel.ISupportInitialize)prev).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox next;
        private PictureBox prev;
        private PictureBox pictureBox2;
        private Label artist;
        private Label album;
        private Label songsNumber;
        private Label year;
        private Label downloads;
        private Button downloadbtn;
    }
}
