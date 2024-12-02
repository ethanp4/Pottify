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
            btnStop = new Button();
            btnShuffle = new Button();
            buttonLoop = new Button();
            label1 = new Label();
            numProgress = new NumericUpDown();
            labelLength = new Label();
            ((System.ComponentModel.ISupportInitialize)numProgress).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(3, 126);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(84, 126);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(71, 23);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(158, 126);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(76, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.None;
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(3, 53);
            labelInfo.MaximumSize = new Size(170, 0);
            labelInfo.MinimumSize = new Size(228, 70);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(228, 70);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "No song is playing. Double click a song or press play to play a random song";
            labelInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(84, 155);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(71, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(158, 155);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(76, 23);
            btnShuffle.TabIndex = 5;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += changePlayMode;
            // 
            // buttonLoop
            // 
            buttonLoop.Location = new Point(3, 155);
            buttonLoop.Name = "buttonLoop";
            buttonLoop.Size = new Size(75, 23);
            buttonLoop.TabIndex = 6;
            buttonLoop.Text = "Loop";
            buttonLoop.UseVisualStyleBackColor = true;
            buttonLoop.Click += changePlayMode;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 7;
            label1.Text = "Song progress:";
            // 
            // numProgress
            // 
            numProgress.DecimalPlaces = 1;
            numProgress.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numProgress.Location = new Point(94, 5);
            numProgress.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numProgress.Name = "numProgress";
            numProgress.Size = new Size(58, 23);
            numProgress.TabIndex = 9;
            numProgress.Enter += songProgressFocus;
            numProgress.KeyDown += songProgressKeyDown;
            numProgress.Leave += songProgressFocus;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(11, 38);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(77, 15);
            labelLength.TabIndex = 10;
            labelLength.Text = "Song Length:";
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelLength);
            Controls.Add(numProgress);
            Controls.Add(label1);
            Controls.Add(buttonLoop);
            Controls.Add(btnShuffle);
            Controls.Add(btnStop);
            Controls.Add(labelInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPlay);
            Controls.Add(btnPrevious);
            Name = "SongControls";
            Size = new Size(234, 180);
            ((System.ComponentModel.ISupportInitialize)numProgress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevious;
        private Button btnPlay;
        private Button btnNext;
        private Label labelInfo;
        private Button btnStop;
        private Button btnShuffle;
        private Button buttonLoop;
        private Label label1;
        private NumericUpDown numProgress;
        private Label labelLength;
    }
}
