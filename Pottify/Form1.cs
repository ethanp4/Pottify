using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Pottify {
    public partial class Form1 : Form {
        string[] files;
        public Form1() {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp
            var songsPath = "..\\..\\..\\Songs";
            //DirectoryInfo d = new DirectoryInfo(songsPath); 
            files = Directory.GetFiles(songsPath, "*.mp3");

            //foreach (var file in files) {
            //    var tfile = TagLib.File.Create(file);
            //    string title = tfile.Tag.Title;
            //    TimeSpan duration = tfile.Properties.Duration;
            //    Debug.WriteLine("Title: {0}, duration: {1}", title, duration);

            //    // change title in the file
            //    tfile.Tag.Title = "my new title";
            //    tfile.Save();
            //}

            foreach (var file in files) {
                var tfile = TagLib.File.Create(file);
                var title = tfile.Tag.Title;
                var duration = tfile.Properties.Duration;
                var author = tfile.Tag.Performers;
                var genre = tfile.Tag.Genres;
                var s = new Song(title, author, Convert.ToInt32(duration.TotalSeconds), genre, file);
                
                songsListView.Items.Add();
            }

            var listItem = new ListViewItem();
            songsListView.Items.Add(listItem);

            songsList.Items.AddRange(files);

            var songs = new AutoCompleteStringCollection();
            songs.AddRange(files);
            textSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;
        }

        private void searchChanged(object sender, EventArgs e) {
            List<string> res = new List<string>();
            var query = textSearch.Text;

            foreach (var item in files) {
                if (item.Contains(query)) {
                    res.Add(item);
                }
            }
            songsList.Items.Clear();
            songsList.Items.AddRange(res.ToArray());
        }
    }
}
