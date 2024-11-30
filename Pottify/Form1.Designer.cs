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
            SuspendLayout();
            // 
            // songsListView
            // 
            songsListView.Location = new Point(232, 23);
            songsListView.Margin = new Padding(3, 2, 3, 2);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(843, 649);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 23);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(214, 23);
            textSearch.TabIndex = 3;
            textSearch.TextChanged += searchChanged;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(12, 277);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(112, 23);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "Set Details View";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnImages
            // 
            btnImages.Location = new Point(12, 306);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(112, 23);
            btnImages.TabIndex = 5;
            btnImages.Text = "Set Images View";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 670);
            Controls.Add(btnImages);
            Controls.Add(btnDetails);
            Controls.Add(textSearch);
            Controls.Add(songsListView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView songsListView;
        private TextBox textSearch;
        private Button btnDetails;
        private Button btnImages;
    }
}
