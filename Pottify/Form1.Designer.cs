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
            btnPlaylist = new Button();
            songControls1 = new SongControls();
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            songsListView.Location = new Point(265, 0);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(980, 915);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(14, 16);
            textSearch.Margin = new Padding(3, 4, 3, 4);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(244, 27);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += searchChanged;
            // 
            // btnDetails
            // 
            btnDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDetails.Location = new Point(14, 572);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(242, 31);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Set Details View";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnImages
            // 
            btnImages.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImages.Location = new Point(14, 608);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(242, 31);
            btnImages.TabIndex = 5;
            btnImages.Text = "Set Images View";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreatePlaylist.Location = new Point(14, 637);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(242, 31);
            btnCreatePlaylist.TabIndex = 6;
            btnCreatePlaylist.Text = "Create playlist";
            btnCreatePlaylist.UseVisualStyleBackColor = true;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(14, 55);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(245, 31);
            btnAll.TabIndex = 7;
            btnAll.Text = "All songs";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(14, 93);
            btnAlbum.Margin = new Padding(3, 4, 3, 4);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(245, 31);
            btnAlbum.TabIndex = 8;
            btnAlbum.Text = "Albums";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnArtist
            // 
            btnArtist.Location = new Point(14, 132);
            btnArtist.Margin = new Padding(3, 4, 3, 4);
            btnArtist.Name = "btnArtist";
            btnArtist.Size = new Size(245, 31);
            btnArtist.TabIndex = 9;
            btnArtist.Text = "Artists";
            btnArtist.UseVisualStyleBackColor = true;
            btnArtist.Click += btnArtists_Click_1;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Location = new Point(14, 171);
            btnPlaylist.Margin = new Padding(3, 4, 3, 4);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Size = new Size(245, 31);
            btnPlaylist.TabIndex = 10;
            btnPlaylist.Text = "Playlists";
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // songControls1
            // 
            songControls1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            songControls1.Location = new Point(1, 675);
            songControls1.Margin = new Padding(3, 5, 3, 5);
            songControls1.Name = "songControls1";
            songControls1.Size = new Size(267, 240);
            songControls1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 916);
            Controls.Add(songControls1);
            Controls.Add(btnPlaylist);
            Controls.Add(btnArtist);
            Controls.Add(btnAlbum);
            Controls.Add(btnAll);
            Controls.Add(btnCreatePlaylist);
            Controls.Add(btnImages);
            Controls.Add(btnDetails);
            Controls.Add(textSearch);
            Controls.Add(songsListView);
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
        private Button btnPlaylist;
        private SongControls songControls1;
    }
}
