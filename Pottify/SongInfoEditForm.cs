using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pottify
{
    public partial class SongInfoEditForm : Form
    {
        public SongInfoEditForm(Song s)
        {
            InitializeComponent();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
