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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            songsListView.Location = new Point(250, 1);
            songsListView.Margin = new Padding(3, 2, 3, 2);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(840, 687);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 12);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(226, 23);
            textSearch.TabIndex = 0;
            textSearch.TextChanged += searchChanged;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(6, 21);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(227, 23);
            btnDetails.TabIndex = 5;
            btnDetails.Text = "Set Details View";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnImages
            // 
            btnImages.Location = new Point(6, 48);
            btnImages.Margin = new Padding(3, 2, 3, 2);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(227, 23);
            btnImages.TabIndex = 6;
            btnImages.Text = "Set Images View";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnCreatePlaylist
            // 
            btnCreatePlaylist.Location = new Point(6, 21);
            btnCreatePlaylist.Margin = new Padding(3, 2, 3, 2);
            btnCreatePlaylist.Name = "btnCreatePlaylist";
            btnCreatePlaylist.Size = new Size(227, 23);
            btnCreatePlaylist.TabIndex = 7;
            btnCreatePlaylist.Text = "Create playlist";
            btnCreatePlaylist.UseVisualStyleBackColor = true;
            btnCreatePlaylist.Click += btnCreatePlaylist_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(6, 22);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(227, 23);
            btnAll.TabIndex = 1;
            btnAll.Text = "All songs";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(6, 51);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(227, 23);
            btnAlbum.TabIndex = 2;
            btnAlbum.Text = "Albums";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnArtist
            // 
            btnArtist.Location = new Point(6, 80);
            btnArtist.Name = "btnArtist";
            btnArtist.Size = new Size(227, 23);
            btnArtist.TabIndex = 3;
            btnArtist.Text = "Artists";
            btnArtist.UseVisualStyleBackColor = true;
            btnArtist.Click += btnArtists_Click_1;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Location = new Point(6, 109);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Size = new Size(227, 23);
            btnPlaylist.TabIndex = 4;
            btnPlaylist.Text = "Playlists";
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // songControls1
            // 
            songControls1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            songControls1.Location = new Point(6, 16);
            songControls1.Margin = new Padding(3, 4, 3, 4);
            songControls1.Name = "songControls1";
            songControls1.Size = new Size(233, 171);
            songControls1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAll);
            groupBox1.Controls.Add(btnAlbum);
            groupBox1.Controls.Add(btnPlaylist);
            groupBox1.Controls.Add(btnArtist);
            groupBox1.Location = new Point(5, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 138);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Views";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDetails);
            groupBox2.Controls.Add(btnImages);
            groupBox2.Location = new Point(5, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 83);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Display modes";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(songControls1);
            groupBox3.Location = new Point(5, 494);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(242, 194);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controls";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnRefresh);
            groupBox4.Controls.Add(btnCreatePlaylist);
            groupBox4.Location = new Point(5, 274);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 81);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Other";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(7, 48);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(226, 23);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh list";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 687);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textSearch);
            Controls.Add(songsListView);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(574, 563);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pottify";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnRefresh;
    }
}
