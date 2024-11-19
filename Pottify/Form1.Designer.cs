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
            songsList = new ListBox();
            textSearch = new TextBox();
            SuspendLayout();
            // 
            // songsList
            // 
            songsList.FormattingEnabled = true;
            songsList.Location = new Point(64, 46);
            songsList.Name = "songsList";
            songsList.Size = new Size(638, 344);
            songsList.TabIndex = 0;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(64, 13);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song, album, or artist";
            textSearch.Size = new Size(638, 27);
            textSearch.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
