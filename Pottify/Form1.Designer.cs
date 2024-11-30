namespace Pottify
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
            songsListView = new ListView();
            textSearch = new TextBox();
            panel1 = new Panel();
            btnArtists = new Button();
            btnAlbum = new Button();
            btnAll = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Location = new Point(267, 2);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(969, 902);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(13, 13);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(225, 48);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += searchChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnArtists);
            panel1.Controls.Add(btnAlbum);
            panel1.Controls.Add(btnAll);
            panel1.Controls.Add(textSearch);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 895);
            panel1.TabIndex = 4;
            // 
            // btnArtists
            // 
            btnArtists.Location = new Point(13, 193);
            btnArtists.Name = "btnArtists";
            btnArtists.Size = new Size(94, 29);
            btnArtists.TabIndex = 4;
            btnArtists.Text = "Artists";
            btnArtists.UseVisualStyleBackColor = true;
            btnArtists.Click += btnArtists_Click_1;
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(13, 144);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(94, 29);
            btnAlbum.TabIndex = 3;
            btnAlbum.Text = "Album";
            btnAlbum.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(13, 98);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(94, 29);
            btnAll.TabIndex = 2;
            btnAll.Text = "All Songs";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 893);
            Controls.Add(panel1);
            Controls.Add(songsListView);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView songsListView;
        private TextBox textSearch;
        private Panel panel1;
        private Button btnAll;
        private Button btnArtists;
        private Button btnAlbum;
    }
}