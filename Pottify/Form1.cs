using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Pottify {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp

            var songsPath = "..\\..\\..\\Songs";
            // songsPath = @"C:\Users\Ethan\Music\";
            Song.initSongList(songsPath);

            var listItem = new ListViewItem();
            songsListView.Items.Add(listItem);

            // songsList.Items.AddRange(files);

            var songs = new AutoCompleteStringCollection();
            // songs.AddRange(files);
            textSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;
        }

        private void searchChanged(object sender, EventArgs e) {
            List<string> res = new List<string>();
            var query = textSearch.Text;

            // foreach (var item in files) {
            //     if (item.Contains(query)) {
            //         res.Add(item);
            //     }
            // }
            songsList.Items.Clear();
            songsList.Items.AddRange(res.ToArray());
        }
    }
}
