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
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(3, 126);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(60, 23);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(67, 126);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(49, 23);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(121, 126);
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
            labelInfo.Location = new Point(3, 53);
            labelInfo.MaximumSize = new Size(170, 0);
            labelInfo.MinimumSize = new Size(170, 70);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(170, 70);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "No song is playing. Double click a song or press play to play a random song";
            labelInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(67, 155);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(49, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(121, 155);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(52, 23);
            btnShuffle.TabIndex = 5;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // buttonLoop
            // 
            buttonLoop.Location = new Point(3, 155);
            buttonLoop.Name = "buttonLoop";
            buttonLoop.Size = new Size(60, 23);
            buttonLoop.TabIndex = 6;
            buttonLoop.Text = "Loop";
            buttonLoop.UseVisualStyleBackColor = true;
            buttonLoop.Click += buttonLoop_Click;
            // 
            // SongControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonLoop);
            Controls.Add(btnShuffle);
            Controls.Add(btnStop);
            Controls.Add(labelInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPlay);
            Controls.Add(btnPrevious);
            Name = "SongControls";
            Size = new Size(234, 180);
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
    }
}
