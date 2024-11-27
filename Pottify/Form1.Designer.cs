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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            textSearch = new TextBox();
            songsListView = new ListView();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPlaylist = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnAlbums = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btnAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textSearch
            // 
            textSearch.Location = new Point(21, 17);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Search for a song";
            textSearch.Size = new Size(225, 27);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += searchChanged;
            // 
            // songsListView
            // 
            songsListView.Location = new Point(264, -5);
            songsListView.Name = "songsListView";
            songsListView.Size = new Size(963, 902);
            songsListView.TabIndex = 2;
            songsListView.UseCompatibleStateImageBehavior = false;
            songsListView.View = View.Details;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.LightGray;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.Transparent;
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(label2);
            bunifuPanel1.Controls.Add(label1);
            bunifuPanel1.Controls.Add(pictureBox1);
            bunifuPanel1.Controls.Add(btnPlaylist);
            bunifuPanel1.Controls.Add(btnAlbums);
            bunifuPanel1.Controls.Add(textSearch);
            bunifuPanel1.Controls.Add(btnAll);
            bunifuPanel1.Location = new Point(-6, -5);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(271, 905);
            bunifuPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 856);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 822);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 602);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 206);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnPlaylist
            // 
            btnPlaylist.AllowAnimations = true;
            btnPlaylist.AllowMouseEffects = true;
            btnPlaylist.AllowToggling = false;
            btnPlaylist.AnimationSpeed = 200;
            btnPlaylist.AutoGenerateColors = false;
            btnPlaylist.AutoRoundBorders = false;
            btnPlaylist.AutoSizeLeftIcon = true;
            btnPlaylist.AutoSizeRightIcon = true;
            btnPlaylist.BackColor = Color.Transparent;
            btnPlaylist.BackColor1 = Color.FromArgb(51, 122, 183);
            btnPlaylist.BackgroundImage = (Image)resources.GetObject("btnPlaylist.BackgroundImage");
            btnPlaylist.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnPlaylist.ButtonText = "Playlists";
            btnPlaylist.ButtonTextMarginLeft = 0;
            btnPlaylist.ColorContrastOnClick = 45;
            btnPlaylist.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnPlaylist.CustomizableEdges = borderEdges1;
            btnPlaylist.DialogResult = DialogResult.None;
            btnPlaylist.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnPlaylist.DisabledFillColor = Color.Empty;
            btnPlaylist.DisabledForecolor = Color.Empty;
            btnPlaylist.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnPlaylist.Font = new Font("Segoe UI", 9F);
            btnPlaylist.ForeColor = Color.White;
            btnPlaylist.IconLeft = null;
            btnPlaylist.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnPlaylist.IconLeftCursor = Cursors.Default;
            btnPlaylist.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnPlaylist.IconMarginLeft = 11;
            btnPlaylist.IconPadding = 10;
            btnPlaylist.IconRight = null;
            btnPlaylist.IconRightAlign = ContentAlignment.MiddleRight;
            btnPlaylist.IconRightCursor = Cursors.Default;
            btnPlaylist.IconRightPadding = new Padding(3, 3, 7, 3);
            btnPlaylist.IconSize = 25;
            btnPlaylist.IdleBorderColor = Color.Empty;
            btnPlaylist.IdleBorderRadius = 0;
            btnPlaylist.IdleBorderThickness = 0;
            btnPlaylist.IdleFillColor = Color.Empty;
            btnPlaylist.IdleIconLeftImage = null;
            btnPlaylist.IdleIconRightImage = null;
            btnPlaylist.IndicateFocus = false;
            btnPlaylist.Location = new Point(34, 338);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnPlaylist.OnDisabledState.BorderRadius = 1;
            btnPlaylist.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnPlaylist.OnDisabledState.BorderThickness = 1;
            btnPlaylist.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnPlaylist.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnPlaylist.OnDisabledState.IconLeftImage = null;
            btnPlaylist.OnDisabledState.IconRightImage = null;
            btnPlaylist.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnPlaylist.onHoverState.BorderRadius = 1;
            btnPlaylist.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnPlaylist.onHoverState.BorderThickness = 1;
            btnPlaylist.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnPlaylist.onHoverState.ForeColor = Color.White;
            btnPlaylist.onHoverState.IconLeftImage = null;
            btnPlaylist.onHoverState.IconRightImage = null;
            btnPlaylist.OnIdleState.BorderColor = Color.DodgerBlue;
            btnPlaylist.OnIdleState.BorderRadius = 1;
            btnPlaylist.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnPlaylist.OnIdleState.BorderThickness = 1;
            btnPlaylist.OnIdleState.FillColor = Color.DodgerBlue;
            btnPlaylist.OnIdleState.ForeColor = Color.White;
            btnPlaylist.OnIdleState.IconLeftImage = null;
            btnPlaylist.OnIdleState.IconRightImage = null;
            btnPlaylist.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnPlaylist.OnPressedState.BorderRadius = 1;
            btnPlaylist.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnPlaylist.OnPressedState.BorderThickness = 1;
            btnPlaylist.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnPlaylist.OnPressedState.ForeColor = Color.White;
            btnPlaylist.OnPressedState.IconLeftImage = null;
            btnPlaylist.OnPressedState.IconRightImage = null;
            btnPlaylist.Size = new Size(188, 49);
            btnPlaylist.TabIndex = 2;
            btnPlaylist.TextAlign = ContentAlignment.MiddleCenter;
            btnPlaylist.TextAlignment = HorizontalAlignment.Center;
            btnPlaylist.TextMarginLeft = 0;
            btnPlaylist.TextPadding = new Padding(0);
            btnPlaylist.UseDefaultRadiusAndThickness = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // btnAlbums
            // 
            btnAlbums.AllowAnimations = true;
            btnAlbums.AllowMouseEffects = true;
            btnAlbums.AllowToggling = false;
            btnAlbums.AnimationSpeed = 200;
            btnAlbums.AutoGenerateColors = false;
            btnAlbums.AutoRoundBorders = false;
            btnAlbums.AutoSizeLeftIcon = true;
            btnAlbums.AutoSizeRightIcon = true;
            btnAlbums.BackColor = Color.Transparent;
            btnAlbums.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAlbums.BackgroundImage = (Image)resources.GetObject("btnAlbums.BackgroundImage");
            btnAlbums.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAlbums.ButtonText = "Albums";
            btnAlbums.ButtonTextMarginLeft = 0;
            btnAlbums.ColorContrastOnClick = 45;
            btnAlbums.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnAlbums.CustomizableEdges = borderEdges2;
            btnAlbums.DialogResult = DialogResult.None;
            btnAlbums.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAlbums.DisabledFillColor = Color.Empty;
            btnAlbums.DisabledForecolor = Color.Empty;
            btnAlbums.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAlbums.Font = new Font("Segoe UI", 9F);
            btnAlbums.ForeColor = Color.White;
            btnAlbums.IconLeft = null;
            btnAlbums.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAlbums.IconLeftCursor = Cursors.Default;
            btnAlbums.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAlbums.IconMarginLeft = 11;
            btnAlbums.IconPadding = 10;
            btnAlbums.IconRight = null;
            btnAlbums.IconRightAlign = ContentAlignment.MiddleRight;
            btnAlbums.IconRightCursor = Cursors.Default;
            btnAlbums.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAlbums.IconSize = 25;
            btnAlbums.IdleBorderColor = Color.Empty;
            btnAlbums.IdleBorderRadius = 0;
            btnAlbums.IdleBorderThickness = 0;
            btnAlbums.IdleFillColor = Color.Empty;
            btnAlbums.IdleIconLeftImage = null;
            btnAlbums.IdleIconRightImage = null;
            btnAlbums.IndicateFocus = false;
            btnAlbums.Location = new Point(34, 269);
            btnAlbums.Name = "btnAlbums";
            btnAlbums.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAlbums.OnDisabledState.BorderRadius = 1;
            btnAlbums.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAlbums.OnDisabledState.BorderThickness = 1;
            btnAlbums.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAlbums.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAlbums.OnDisabledState.IconLeftImage = null;
            btnAlbums.OnDisabledState.IconRightImage = null;
            btnAlbums.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAlbums.onHoverState.BorderRadius = 1;
            btnAlbums.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAlbums.onHoverState.BorderThickness = 1;
            btnAlbums.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAlbums.onHoverState.ForeColor = Color.White;
            btnAlbums.onHoverState.IconLeftImage = null;
            btnAlbums.onHoverState.IconRightImage = null;
            btnAlbums.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAlbums.OnIdleState.BorderRadius = 1;
            btnAlbums.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAlbums.OnIdleState.BorderThickness = 1;
            btnAlbums.OnIdleState.FillColor = Color.DodgerBlue;
            btnAlbums.OnIdleState.ForeColor = Color.White;
            btnAlbums.OnIdleState.IconLeftImage = null;
            btnAlbums.OnIdleState.IconRightImage = null;
            btnAlbums.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAlbums.OnPressedState.BorderRadius = 1;
            btnAlbums.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAlbums.OnPressedState.BorderThickness = 1;
            btnAlbums.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnAlbums.OnPressedState.ForeColor = Color.White;
            btnAlbums.OnPressedState.IconLeftImage = null;
            btnAlbums.OnPressedState.IconRightImage = null;
            btnAlbums.Size = new Size(188, 49);
            btnAlbums.TabIndex = 1;
            btnAlbums.TextAlign = ContentAlignment.MiddleCenter;
            btnAlbums.TextAlignment = HorizontalAlignment.Center;
            btnAlbums.TextMarginLeft = 0;
            btnAlbums.TextPadding = new Padding(0);
            btnAlbums.UseDefaultRadiusAndThickness = true;
            btnAlbums.Click += btnAlbums_Click;
            // 
            // btnAll
            // 
            btnAll.AllowAnimations = true;
            btnAll.AllowMouseEffects = true;
            btnAll.AllowToggling = false;
            btnAll.AnimationSpeed = 200;
            btnAll.AutoGenerateColors = false;
            btnAll.AutoRoundBorders = false;
            btnAll.AutoSizeLeftIcon = true;
            btnAll.AutoSizeRightIcon = true;
            btnAll.BackColor = Color.Transparent;
            btnAll.BackColor1 = Color.FromArgb(51, 122, 183);
            btnAll.BackgroundImage = (Image)resources.GetObject("btnAll.BackgroundImage");
            btnAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAll.ButtonText = "All Songs";
            btnAll.ButtonTextMarginLeft = 0;
            btnAll.ColorContrastOnClick = 45;
            btnAll.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnAll.CustomizableEdges = borderEdges3;
            btnAll.DialogResult = DialogResult.None;
            btnAll.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            btnAll.DisabledFillColor = Color.Empty;
            btnAll.DisabledForecolor = Color.Empty;
            btnAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAll.Font = new Font("Segoe UI", 9F);
            btnAll.ForeColor = Color.White;
            btnAll.IconLeft = null;
            btnAll.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnAll.IconLeftCursor = Cursors.Default;
            btnAll.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnAll.IconMarginLeft = 11;
            btnAll.IconPadding = 10;
            btnAll.IconRight = null;
            btnAll.IconRightAlign = ContentAlignment.MiddleRight;
            btnAll.IconRightCursor = Cursors.Default;
            btnAll.IconRightPadding = new Padding(3, 3, 7, 3);
            btnAll.IconSize = 25;
            btnAll.IdleBorderColor = Color.Empty;
            btnAll.IdleBorderRadius = 0;
            btnAll.IdleBorderThickness = 0;
            btnAll.IdleFillColor = Color.Empty;
            btnAll.IdleIconLeftImage = null;
            btnAll.IdleIconRightImage = null;
            btnAll.IndicateFocus = false;
            btnAll.Location = new Point(34, 205);
            btnAll.Name = "btnAll";
            btnAll.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            btnAll.OnDisabledState.BorderRadius = 1;
            btnAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAll.OnDisabledState.BorderThickness = 1;
            btnAll.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnAll.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnAll.OnDisabledState.IconLeftImage = null;
            btnAll.OnDisabledState.IconRightImage = null;
            btnAll.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            btnAll.onHoverState.BorderRadius = 1;
            btnAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAll.onHoverState.BorderThickness = 1;
            btnAll.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            btnAll.onHoverState.ForeColor = Color.White;
            btnAll.onHoverState.IconLeftImage = null;
            btnAll.onHoverState.IconRightImage = null;
            btnAll.OnIdleState.BorderColor = Color.DodgerBlue;
            btnAll.OnIdleState.BorderRadius = 1;
            btnAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAll.OnIdleState.BorderThickness = 1;
            btnAll.OnIdleState.FillColor = Color.DodgerBlue;
            btnAll.OnIdleState.ForeColor = Color.White;
            btnAll.OnIdleState.IconLeftImage = null;
            btnAll.OnIdleState.IconRightImage = null;
            btnAll.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            btnAll.OnPressedState.BorderRadius = 1;
            btnAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAll.OnPressedState.BorderThickness = 1;
            btnAll.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            btnAll.OnPressedState.ForeColor = Color.White;
            btnAll.OnPressedState.IconLeftImage = null;
            btnAll.OnPressedState.IconRightImage = null;
            btnAll.Size = new Size(188, 49);
            btnAll.TabIndex = 0;
            btnAll.TextAlign = ContentAlignment.MiddleCenter;
            btnAll.TextAlignment = HorizontalAlignment.Center;
            btnAll.TextMarginLeft = 0;
            btnAll.TextPadding = new Padding(0);
            btnAll.UseDefaultRadiusAndThickness = true;
            btnAll.Click += btnAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 893);
            Controls.Add(bunifuPanel1);
            Controls.Add(songsListView);
            Name = "Form1";
            Text = "Form1";
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textSearch;
        private ListView songsListView;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaylist;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlbums;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
