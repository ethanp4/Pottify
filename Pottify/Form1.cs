using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

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
            songsListView.MouseDoubleClick += songDoubleClick; //used to play a song
            songsListView.MouseClick += listViewClick; //used for right clicking a song
            songsListView.MultiSelect = false;
            songsListView.FullRowSelect = true;
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);
            foreach (var s in Song.songsList) //add songs to the list
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
            foreach (var i in songsListView.Items) //create a copy of the list for searching
            {
                fullList.Add((ListViewItem)i);
            }
            
            var songs = new AutoCompleteStringCollection(); //set autocomplete source
            foreach (var title in Song.songsList.Select(s => s.title))
            {
                songs.Add(title);
            }
            textSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;
        }

        private void addToPlaylistEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            var playlist = ((ToolStripMenuItem)sender).Tag; //will be a playlist object
            Debug.WriteLine($"Add song {targetSong} to playlist {playlist}");
        }

        private void editSongEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            Debug.WriteLine($"Open edit form for {targetSong}");
        }

        private void deleteSongEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            Debug.WriteLine($"Delete song {targetSong}");
        }

        private void listViewClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = songsListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    var songContextMenu = new ContextMenuStrip();
                    //parent items
                    var playlistsParent = new ToolStripMenuItem("Add to playlist");
                    var editSong = new ToolStripMenuItem("Edit song");
                    editSong.Click += editSongEvent;
                    var deleteSong = new ToolStripMenuItem("Delete song");
                    deleteSong.Click += deleteSongEvent;

                    //child items (playlists)
                    var playlist1 = new ToolStripMenuItem("Playlist 1");
                    playlist1.Tag = "Fake playlist object 1";
                    playlist1.Click += addToPlaylistEvent;
                    var playlist2 = new ToolStripMenuItem("Playlist 2");
                    playlist2.Tag = "Fake playlist object 2";
                    playlist2.Click += addToPlaylistEvent;

                    //add the children
                    playlistsParent.DropDownItems.Add(playlist1);
                    playlistsParent.DropDownItems.Add(playlist2);

                    //add the items to the context menu
                    songContextMenu.Items.Add(playlistsParent);
                    songContextMenu.Items.Add(editSong);
                    songContextMenu.Items.Add(deleteSong);

                    songContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void songDoubleClick(object sender, EventArgs e)
        {
            Song selectedSong = (Song)songsListView.SelectedItems[0].Tag;
            Debug.WriteLine($"Play song {selectedSong}");
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
