using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Pottify {
    public partial class Form1 : Form
    {
        private List<ListViewItem> fullList = new();
        private List<string> artistList = new(); // Stores the list of unique artists
        enum VIEWTYPE { SONG, ARTIST, PLAYLIST, ALBUM }
        private VIEWTYPE viewType = VIEWTYPE.SONG;

        public Form1()
        {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp

            initSongs();
        }

        ////////////////////Create initial view//////////////////////////////
        private void initSongs()
        {
            var songsPath = "..\\..\\..\\Songs";
            // songsPath = @"C:\Users\Ethan\Music\";
            //load songs and set listview columns
            Song.initSongList(songsPath);
            LoadArtists(); // load artists into the artistList
            //changeView(viewMode.ALL);

            songsListView.View = View.LargeIcon;
            Song.images.ImageSize = new Size(50, 50);
            songsListView.LargeImageList = Song.images;
            songsListView.MouseDoubleClick += itemDoubleClick; //used to play a song
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
                songsListView.Items.Add(createSongListViewItem(s));
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

        private ListViewItem createSongListViewItem(Song s)
        {
            var listItem = new ListViewItem();
            listItem.Text = s.title;
            listItem.ImageKey = s.id.ToString();
            listItem.SubItems.Add(s.artist[0]);
            listItem.SubItems.Add(s.album);
            listItem.SubItems.Add($"{s.trackNumber} of {s.trackCount}");
            listItem.SubItems.Add(s.year == 0 ? "Not set" : s.year.ToString());
            listItem.Tag = s; //get data from here when clicked or something
            return listItem;
        }
        ///////////////////////////////////////////ARTISTS VIEW////////////////////////////////////
        private void LoadArtists()
        {
            artistList = Song.songsList
                .SelectMany(s => s.artist)
                .Distinct()
                .OrderBy(a => a)
                .ToList();
        }

        private void ShowArtists()
        {
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Artist", 300);

            foreach (var artist in artistList)
            {
                var listItem = new ListViewItem();
                listItem.Text = artist;
                listItem.Tag = artist;
                songsListView.Items.Add(listItem);
            }

        }

        //show songs by a specific artist
        private void ShowSongsByArtist(string artist)
        {
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);

            // gilters songs by the selected artist
            var songsByArtist = Song.songsList.Where(s => s.artist.Contains(artist)).ToList();

            foreach (var s in songsByArtist)
            {
                songsListView.Items.Add(createSongListViewItem(s));
            }
            viewType = VIEWTYPE.SONG;
        }
        ///////////////////////////////EVENTS/////////////////////////////
        private void addToPlaylistEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            var playlist = ((ToolStripMenuItem)sender).Tag; //will be a playlist object
            Debug.WriteLine($"Add song {targetSong} to playlist {playlist}");
        }

        private void editSongEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            var editForm = new SongInfoEditForm(targetSong);
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
                    switch (viewType)
                    {
                        case VIEWTYPE.SONG:
                            var songContextMenu = new ContextMenuStrip();
                            //parent items
                            var playlistsParent = new ToolStripMenuItem("Add to playlist");
                            var editSong = new ToolStripMenuItem("Edit song");
                            editSong.Click += editSongEvent;
                            var deleteSong = new ToolStripMenuItem("Delete song");
                            deleteSong.Click += deleteSongEvent;

                            //child items (playlists)
                            foreach (var p in Playlist.getAllPlaylists())
                            {
                                var playlist = new ToolStripMenuItem(p.name);
                                playlist.Tag = p;
                                playlist.Click += addToPlaylistEvent;
                                playlistsParent.DropDownItems.Add(playlist);
                            }

                            if (Playlist.getAllPlaylists().Count == 0)
                            {
                                var placeholder = new ToolStripMenuItem("No playlists have been added");
                                playlistsParent.DropDownItems.Add(placeholder);
                            }

                            //add the items to the context menu
                            songContextMenu.Items.Add(playlistsParent);
                            songContextMenu.Items.Add(editSong);
                            songContextMenu.Items.Add(deleteSong);
                            songContextMenu.Show(Cursor.Position);
                            break;
                        case VIEWTYPE.ARTIST:
                            break;
                        case VIEWTYPE.PLAYLIST:
                            break;
                        case VIEWTYPE.ALBUM:
                            break;
                    }
                {
                }
            }
        }

        private void itemDoubleClick(object sender, EventArgs e)
        {
            switch (viewType)
            {
                case VIEWTYPE.SONG:
                    Song selectedSong = (Song)songsListView.SelectedItems[0].Tag;
                    Debug.WriteLine($"Play song {selectedSong}");
                    break;
                case VIEWTYPE.ARTIST:
                    var selectedArtist = songsListView.SelectedItems[0].Tag.ToString();
                    Debug.WriteLine("artist was double clicked: " + selectedArtist);
                    ShowSongsByArtist(selectedArtist);
                    break;
                case VIEWTYPE.PLAYLIST:
                    break;
                case VIEWTYPE.ALBUM:
                    break;
            }

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

        private void btnDetails_Click(object sender, EventArgs e) //change view mode
        {
            songsListView.View = View.Details;
        }

        private void btnImages_Click(object sender, EventArgs e) //change view mode
        {
            songsListView.View = View.LargeIcon;
        }

        private void btnAll_Click(object sender, EventArgs e) //change view contents
        {
            if (viewType == VIEWTYPE.SONG) { return; } //do nothing if its already this
            viewType = VIEWTYPE.SONG;
            songsListView.Items.Clear();
            songsListView.Items.AddRange(fullList.ToArray()); // Restore full song list
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);
        }

        //Event handler for "Artists" button
        private void btnArtists_Click_1(object sender, EventArgs e) //change view contents
        {
            if (viewType == VIEWTYPE.ARTIST) { return; }
            viewType = VIEWTYPE.ARTIST;
            ShowArtists();
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            var createForm = new CreatePlaylistForm();
            var res = createForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                new Playlist(createForm.name, createForm.description);
            }
        }
    }
}
