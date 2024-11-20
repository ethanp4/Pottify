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
        private void InitializeComponent() {
            ListViewItem listViewItem1 = new ListViewItem("dsadsad");
            songsList = new ListBox();
            textSearch = new TextBox();
            songsListView = new ListView();
            Title = new ColumnHeader();
            Artist = new ColumnHeader();
            Length = new ColumnHeader();
            Genre = new ColumnHeader();
            SuspendLayout();
            // 
            // songsList
            // 
            songsList.FormattingEnabled = true;
            songsList.Location = new Point(64, 46);
            songsList.Name = "songsList";
            songsList.Size = new Size(178, 344);
            songsList.TabIndex = 0;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(64, 13);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song, album, or artist";
            textSearch.Size = new Size(638, 27);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += searchChanged;
            // 
            // songsListView
            // 
            songsListView.Columns.AddRange(new ColumnHeader[] { Title, Artist, Length, Genre });
            songsListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            songsListView.Location = new Point(248, 46);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(454, 344);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // Title
            // 
            Title.Text = "Title";
            // 
            // Artist
            // 
            Artist.Text = "Artist";
            // 
            // Length
            // 
            Length.Text = "Length";
            // 
            // Genre
            // 
            Genre.Text = "Genre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(songsListView);
            Controls.Add(textSearch);
            Controls.Add(songsList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox songsList;
        private TextBox textSearch;
        private ListView songsListView;
        private ColumnHeader Title;
        private ColumnHeader Artist;
        private ColumnHeader Length;
        private ColumnHeader Genre;
    }
}
