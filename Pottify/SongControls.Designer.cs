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
            components = new System.ComponentModel.Container();
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
            tooltipSongProgressHelp = new ToolTip(components);
            volumeSlider1 = new NAudio.Gui.VolumeSlider();
            ((System.ComponentModel.ISupportInitialize)numProgress).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(0, 159);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 31);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(93, 159);
            btnPlay.Margin = new Padding(3, 4, 3, 4);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(81, 31);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(177, 159);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(87, 31);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(0, 61);
            labelInfo.MaximumSize = new Size(194, 0);
            labelInfo.MinimumSize = new Size(261, 93);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(261, 93);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "No song is playing. Double click a song or press play to play a random song";
            labelInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(93, 197);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(81, 31);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(177, 197);
            btnShuffle.Margin = new Padding(3, 4, 3, 4);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(87, 31);
            btnShuffle.TabIndex = 6;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += changePlayMode;
            // 
            // buttonLoop
            // 
            buttonLoop.Location = new Point(0, 197);
            buttonLoop.Margin = new Padding(3, 4, 3, 4);
            buttonLoop.Name = "buttonLoop";
            buttonLoop.Size = new Size(86, 31);
            buttonLoop.TabIndex = 4;
            buttonLoop.Text = "Loop";
            buttonLoop.UseVisualStyleBackColor = true;
            buttonLoop.Click += changePlayMode;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 7;
            label1.Text = "Song Progress:";
            // 
            // numProgress
            // 
            numProgress.DecimalPlaces = 1;
            numProgress.Location = new Point(108, 0);
            numProgress.Margin = new Padding(3, 4, 3, 4);
            numProgress.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numProgress.Name = "numProgress";
            numProgress.Size = new Size(66, 27);
            numProgress.TabIndex = 0;
            numProgress.Click += songProgressClicked;
            numProgress.KeyDown += songProgressKeyDown;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(177, 4);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(85, 20);
            labelLength.TabIndex = 10;
            labelLength.Text = "Secs / Total";
            // 
            // tooltipSongProgressHelp
            // 
            tooltipSongProgressHelp.ToolTipTitle = "Song Progress in Seconds";
            // 
            // volumeSlider1
            // 
            volumeSlider1.Location = new Point(5, 34);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new Size(258, 30);
            volumeSlider1.TabIndex = 11;
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(volumeSlider1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SongControls";
            Size = new Size(266, 229);
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
        private ToolTip tooltipSongProgressHelp;
        private NAudio.Gui.VolumeSlider volumeSlider1;
    }
}