namespace Pottify {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            songsListView = new ListView();
            textSearch = new TextBox();
            btnDetails = new Button();
            btnImages = new Button();
            btnCreatePlaylist = new Button();
            btnAll = new Button();
            btnAlbum = new Button();
            btnArtist = new Button();
            button4 = new Button();
            btnReload = new Button();
            songControls1 = new SongControls();
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            songsListView.Location = new Point(232, 0);
            songsListView.Margin = new Padding(3, 2, 3, 2);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(858, 687);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 12);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(214, 23);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += searchChanged;
            // 
            // btnDetails
            // 
            btnDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDetails.Location = new Point(12, 429);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(212, 23);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Set Details View";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnImages
            // 
            btnImages.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImages.Location = new Point(12, 456);
            btnImages.Margin = new Padding(3, 2, 3, 2);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(212, 23);
            btnImages.TabIndex = 5;
            btnImages.Text = "Set Images View";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreatePlaylist.Location = new Point(12, 478);
            btnCreatePlaylist.Margin = new Padding(3, 2, 3, 2);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(212, 23);
            btnCreatePlaylist.TabIndex = 6;
            btnCreatePlaylist.Text = "Create playlist";
            btnCreatePlaylist.UseVisualStyleBackColor = true;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(12, 41);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(214, 23);
            btnAll.TabIndex = 7;
            btnAll.Text = "All songs";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(12, 70);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(214, 23);
            btnAlbum.TabIndex = 8;
            btnAlbum.Text = "Albums";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnArtist
            // 
            btnArtist.Location = new Point(12, 99);
            btnArtist.Name = "btnArtist";
            btnArtist.Size = new Size(214, 23);
            btnArtist.TabIndex = 9;
            btnArtist.Text = "Artists";
            btnArtist.UseVisualStyleBackColor = true;
            btnArtist.Click += btnArtists_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(12, 128);
            button4.Name = "button4";
            button4.Size = new Size(214, 23);
            button4.TabIndex = 10;
            button4.Text = "Playlists";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReload.Location = new Point(12, 396);
            btnReload.Margin = new Padding(3, 2, 3, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(214, 29);
            btnReload.TabIndex = 12;
            btnReload.Text = "Reload songs";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // songControls1
            // 
            songControls1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            songControls1.Location = new Point(1, 506);
            songControls1.Name = "songControls1";
            songControls1.Size = new Size(234, 180);
            songControls1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 687);
            Controls.Add(songControls1);
            Controls.Add(btnReload);
            Controls.Add(button4);
            Controls.Add(btnArtist);
            Controls.Add(btnAlbum);
            Controls.Add(btnAll);
            Controls.Add(btnCreatePlaylist);
            Controls.Add(btnImages);
            Controls.Add(btnDetails);
            Controls.Add(textSearch);
            Controls.Add(songsListView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pottify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView songsListView;
        private TextBox textSearch;
        private Button btnDetails;
        private Button btnImages;
        private Button btnCreatePlaylist;
        private Button btnAll;
        private Button btnAlbum;
        private Button btnArtist;
        private Button button4;
        private Button btnReload;
        private SongControls songControls1;
    }
}
