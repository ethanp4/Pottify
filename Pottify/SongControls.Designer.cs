namespace Pottify
{
    partial class SongControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrevious = new Button();
            btnPlay = new Button();
            btnNext = new Button();
            labelInfo = new Label();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(0, 85);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(60, 23);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(66, 85);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(51, 23);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(123, 85);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(49, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.None;
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(6, 12);
            labelInfo.MaximumSize = new Size(170, 0);
            labelInfo.MinimumSize = new Size(170, 70);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(170, 70);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "No song playing";
            labelInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPlay);
            Controls.Add(btnPrevious);
            Name = "SongControls";
            Size = new Size(210, 108);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevious;
        private Button btnPlay;
        private Button btnNext;
        private Label labelInfo;
    }
}
