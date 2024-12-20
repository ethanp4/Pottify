﻿namespace Pottify
{
    public partial class SongInfoEditForm : Form
    {
        private Song song;
        public SongInfoEditForm(Song s, bool disabled)
        {
            InitializeComponent();
            song = s;
            Text = $"Information for {s}";
            textTitle.Text = s.title;
            textArtist.Text = s.artist;
            textGenre.Text = s.genre;
            textAlbum.Text = s.album;
            textCopyright.Text = s.copyright;
            textComments.Text = s.comments;
            labelFilePath.Text = "File path: " + Path.GetFullPath(s.filePath);
            labelID.Text = "Internal ID: " + s.id.ToString();
            songImage.Image = s.getImageAsBitmap();
            numTrackNumber.Value = s.trackNumber;
            numTrackCount.Value = s.trackCount;
            numYear.Value = s.year;
            if (disabled)
            {
                btnSave.Enabled = false;
                btnSave.Text = "Stop the song to save";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            song.title = textTitle.Text;
            song.artist = textArtist.Text;
            song.genre = textGenre.Text;
            song.album = textAlbum.Text;
            song.copyright = textCopyright.Text;
            song.comments = textComments.Text;
            song.trackNumber = (uint)numTrackNumber.Value;
            song.trackCount = (uint)numTrackCount.Value;
            song.year = (uint)numYear.Value;
            try
            {
                song.saveMetadata();
                MessageBox.Show("Successfully saved song");
                Form1.instance.reinitSongs(false);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save song: {ex.Message}"); //usually due to the file being used by another process (its being played)
            }
        }
    }
}
