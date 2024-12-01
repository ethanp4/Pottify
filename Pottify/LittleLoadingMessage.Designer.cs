namespace Pottify
{
    partial class LittleLoadingMessage
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
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 66);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 0;
            label1.Text = "Please wait while we load your library...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(52, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(212, 23);
            progressBar1.TabIndex = 1;
            // 
            // LittleLoadingMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "LittleLoadingMessage";
            Size = new Size(322, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
    }
}
