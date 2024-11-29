using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Pottify {
    public partial class Form1 : Form
    {
        private List<ListViewItem> fullList = new();
        enum viewMode { ALL, ALBUM, PLAYLIST }

        public Form1()
        {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp

            var songsPath = "..\\..\\..\\Songs";
            // songsPath = @"C:\Users\Ethan\Music\";
            //load songs and set listview columns
            Song.initSongList(songsPath);
            //changeView(viewMode.ALL);

            songsListView.View = View.LargeIcon;
            Song.images.ImageSize = new Size(50, 50);
            songsListView.LargeImageList = Song.images;
            songsListView.MouseDoubleClick += songDoubleClick;
            songsListView.MultiSelect = false;
            songsListView.FullRowSelect = true;
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);
            foreach (var s in Song.songsList)
            {
                var listItem = new ListViewItem();
                listItem.Text = s.title;
                listItem.ImageKey = s.id.ToString();
                listItem.SubItems.Add(s.artist[0]);
                listItem.SubItems.Add(s.album);
                listItem.SubItems.Add($"{s.trackNumber} of {s.trackCount}");
                listItem.SubItems.Add(s.year == 0 ? "Not set" : s.year.ToString());
                listItem.Tag = s; //get data from here when clicked or something
                songsListView.Items.Add(listItem);
            }
            foreach (var i in songsListView.Items)
            {
                fullList.Add((ListViewItem)i);
            }
            // fullList.AddRange((IEnumerable<ListViewItem>)songsListView.Items); //need to create a copy for filtering
            //set autocomplete source
            var songs = new AutoCompleteStringCollection();
            foreach (var title in Song.songsList.Select(s => s.title))
            {
                songs.Add(title);
            }
            textSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;
        }

        private void songDoubleClick(object sender, EventArgs e)
        {
            Song selectedSong = (Song)songsListView.SelectedItems[0].Tag;
            Debug.WriteLine("song was double clicked " + selectedSong);
        }

        //searching for now
        private void searchChanged(object sender, EventArgs e)
        {
            // var query = sender.Text.ToLower();
            var query = textSearch.Text.ToLower();
            if (query == "")
            {
                songsListView.Items.Clear();
                songsListView.Items.AddRange(fullList.ToArray());
                return;
            }
            // var items = songsListView.Items;
            var items = fullList;
            var res = new List<ListViewItem>();
            foreach (ListViewItem item in items)
            {
                if (item.Text.ToLower().Contains(query))
                {
                    res.Add(item);
                }
            }
            songsListView.Items.Clear();
            songsListView.Items.AddRange(res.ToArray());
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            songsListView.View = View.Details;
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            songsListView.View = View.LargeIcon;
        }
    }
}
