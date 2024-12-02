namespace Pottify
{
    partial class SongInfoEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textTitle = new TextBox();
            textArtist = new TextBox();
            textGenre = new TextBox();
            textAlbum = new TextBox();
            textCopyright = new TextBox();
            textComments = new TextBox();
            labelFilePath = new Label();
            labelID = new Label();
            songImage = new PictureBox();
            btnSave = new Button();
            btnCancel = new Button();
            numTrackNumber = new NumericUpDown();
            numTrackCount = new NumericUpDown();
            label1 = new Label();
            numYear = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)songImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTrackNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTrackCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.Location = new Point(263, 48);
            textTitle.Name = "textTitle";
            textTitle.PlaceholderText = "Title";
            textTitle.Size = new Size(164, 23);
            textTitle.TabIndex = 0;
            // 
            // textArtist
            // 
            textArtist.Location = new Point(263, 77);
            textArtist.Name = "textArtist";
            textArtist.PlaceholderText = "Artist";
            textArtist.Size = new Size(164, 23);
            textArtist.TabIndex = 1;
            // 
            // textGenre
            // 
            textGenre.Location = new Point(263, 106);
            textGenre.Name = "textGenre";
            textGenre.PlaceholderText = "Genre";
            textGenre.Size = new Size(164, 23);
            textGenre.TabIndex = 2;
            // 
            // textAlbum
            // 
            textAlbum.Location = new Point(263, 135);
            textAlbum.Name = "textAlbum";
            textAlbum.PlaceholderText = "Album";
            textAlbum.Size = new Size(164, 23);
            textAlbum.TabIndex = 3;
            // 
            // textCopyright
            // 
            textCopyright.Location = new Point(263, 164);
            textCopyright.Name = "textCopyright";
            textCopyright.PlaceholderText = "Copyright";
            textCopyright.Size = new Size(164, 23);
            textCopyright.TabIndex = 4;
            // 
            // textComments
            // 
            textComments.Location = new Point(504, 48);
            textComments.Name = "textComments";
            textComments.PlaceholderText = "Comments";
            textComments.Size = new Size(165, 23);
            textComments.TabIndex = 5;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Location = new Point(34, 224);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(94, 15);
            labelFilePath.TabIndex = 10;
            labelFilePath.Text = "SONG FILE PATH";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(34, 239);
            labelID.Name = "labelID";
            labelID.Size = new Size(53, 15);
            labelID.TabIndex = 11;
            labelID.Text = "SONG ID";
            // 
            // songImage
            // 
            songImage.Location = new Point(34, 48);
            songImage.Name = "songImage";
            songImage.Size = new Size(164, 168);
            songImage.SizeMode = PictureBoxSizeMode.StretchImage;
            songImage.TabIndex = 12;
            songImage.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(214, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save changes to original file";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(384, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // numTrackNumber
            // 
            numTrackNumber.Location = new Point(504, 106);
            numTrackNumber.Name = "numTrackNumber";
            numTrackNumber.Size = new Size(76, 23);
            numTrackNumber.TabIndex = 7;
            // 
            // numTrackCount
            // 
            numTrackCount.Location = new Point(599, 106);
            numTrackCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTrackCount.Name = "numTrackCount";
            numTrackCount.Size = new Size(70, 23);
            numTrackCount.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(583, 110);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 17;
            label1.Text = "/";
            // 
            // numYear
            // 
            numYear.Location = new Point(504, 75);
            numYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(165, 23);
            numYear.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 51);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 20;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 82);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 21;
            label3.Text = "Artist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 22;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 138);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 23;
            label5.Text = "Album";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 167);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 24;
            label6.Text = "Copyright";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 51);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 25;
            label7.Text = "Comments";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(469, 80);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 26;
            label8.Text = "Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 110);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 27;
            label9.Text = "Track No.";
            // 
            // SongInfoEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 302);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numYear);
            Controls.Add(label1);
            Controls.Add(numTrackCount);
            Controls.Add(numTrackNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(songImage);
            Controls.Add(labelID);
            Controls.Add(labelFilePath);
            Controls.Add(textComments);
            Controls.Add(textCopyright);
            Controls.Add(textAlbum);
            Controls.Add(textGenre);
            Controls.Add(textArtist);
            Controls.Add(textTitle);
            MaximumSize = new Size(734, 341);
            MinimumSize = new Size(734, 341);
            Name = "SongInfoEditForm";
            Text = "SongInfoEditForm";
            ((System.ComponentModel.ISupportInitialize)songImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTrackNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTrackCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitle;
        private TextBox textArtist;
        private TextBox textGenre;
        private TextBox textAlbum;
        private TextBox textCopyright;
        private TextBox textComments;
        private Label labelFilePath;
        private Label labelID;
        private PictureBox songImage;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numTrackNumber;
        private NumericUpDown numTrackCount;
        private Label label1;
        private NumericUpDown numYear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}