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
            songControls1 = new SongControls();
            btnReload = new Button();
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Location = new Point(265, 31);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(963, 864);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(14, 31);
            textSearch.Margin = new Padding(3, 4, 3, 4);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(244, 27);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += searchChanged;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(12, 401);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(128, 31);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Set Details View";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnImages
            // 
            btnImages.Location = new Point(12, 430);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(128, 31);
            btnImages.TabIndex = 5;
            btnImages.Text = "Set Images View";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.Location = new Point(12, 459);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(128, 31);
            btnCreatePlaylist.TabIndex = 6;
            btnCreatePlaylist.Text = "Create playlist";
            btnCreatePlaylist.UseVisualStyleBackColor = true;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(14, 127);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(86, 31);
            btnAll.TabIndex = 7;
            btnAll.Text = "All songs";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(14, 165);
            btnAlbum.Margin = new Padding(3, 4, 3, 4);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(86, 31);
            btnAlbum.TabIndex = 8;
            btnAlbum.Text = "Albums";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnArtist
            // 
            btnArtist.Location = new Point(14, 204);
            btnArtist.Margin = new Padding(3, 4, 3, 4);
            btnArtist.Name = "btnArtist";
            btnArtist.Size = new Size(86, 31);
            btnArtist.TabIndex = 9;
            btnArtist.Text = "Artists";
            btnArtist.UseVisualStyleBackColor = true;
            btnArtist.Click += btnArtists_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(14, 243);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 10;
            button4.Text = "Playlists";
            button4.UseVisualStyleBackColor = true;
            // 
            // songControls1
            // 
            songControls1.Location = new Point(1, 487);
            songControls1.Name = "songControls1";
            songControls1.Size = new Size(234, 185);
            songControls1.TabIndex = 11;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(12, 372);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(112, 23);
            btnReload.TabIndex = 12;
            btnReload.Text = "Reload songs";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 670);
            Controls.Add(btnReload);
            Controls.Add(songControls1);
            Controls.Add(button4);
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
        private Button button4;
        private SongControls songControls1;
        private Button btnReload;
    }
}
