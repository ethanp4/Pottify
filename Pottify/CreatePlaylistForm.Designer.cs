﻿namespace Pottify
{
    partial class CreatePlaylistForm
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
            textDescription = new TextBox();
            textName = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textDescription
            // 
            textDescription.Location = new Point(40, 64);
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Playlist Description";
            textDescription.Size = new Size(169, 23);
            textDescription.TabIndex = 1;
            // 
            // textName
            // 
            textName.Location = new Point(40, 35);
            textName.Name = "textName";
            textName.PlaceholderText = "Playlist Name";
            textName.Size = new Size(169, 23);
            textName.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(40, 93);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(93, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create Playlist";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(139, 93);
            btnCancel.MaximumSize = new Size(70, 23);
            btnCancel.MinimumSize = new Size(70, 23);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelClick;
            // 
            // CreatePlaylistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 145);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(textName);
            Controls.Add(textDescription);
            Name = "CreatePlaylistForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Playlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDescription;
        private TextBox textName;
        private Button btnCreate;
        private Button btnCancel;
    }
}