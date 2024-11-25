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
            textSearch = new TextBox();
            songsListView = new ListView();
            SuspendLayout();
            // 
            // textSearch
            // 
            textSearch.Location = new Point(56, 10);
            textSearch.Margin = new Padding(3, 2, 3, 2);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(901, 23);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += searchChanged;
            // 
            // songsListView
            // 
            songsListView.Location = new Point(56, 34);
            songsListView.Margin = new Padding(3, 2, 3, 2);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(901, 550);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 670);
            Controls.Add(songsListView);
            Controls.Add(textSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textSearch;
        private ListView songsListView;
    }
}
