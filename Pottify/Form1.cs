using NAudio.Wave;
using System.Diagnostics;

namespace Pottify
{
    public partial class Form1 : Form
    {
        private List<ListViewItem> fullList = new();
        private List<string> artistList = new(); // Stores the list of unique artists
        private List<string> albumList = new();
        enum VIEWTYPE { SONG, ARTIST, PLAYLIST, ALBUM }
        private VIEWTYPE viewType = VIEWTYPE.SONG;
        public static Form1 instance { get; private set; }
        public Form1()
        {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp

            instance = this;
            oneTimeInitStuff();
            reinitSongs(true);
            Playlist.LoadPlaylists();
            ResizeEnd += onResize;
        }

        private void onResize(object? sender, EventArgs e)
        {
            Debug.WriteLine($"This form is now {Size.ToString()} big");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Playlist.SavePlaylists(); // Save playlists to file
            base.OnFormClosing(e);
        }


        private void oneTimeInitStuff()
        {
            songsListView.View = View.LargeIcon;
            Song.images.ImageSize = new Size(50, 50);
            songsListView.LargeImageList = Song.images;
            songsListView.MouseDoubleClick += itemDoubleClick; //used to play a song
            songsListView.MouseClick += listViewClick; //used for right clicking a song
            songsListView.MultiSelect = false;
            songsListView.FullRowSelect = true;
        }

        ////////////////////Create initial view//////////////////////////////
        public void reinitSongs(bool loadAllSongs) //this function is rerun if stuff is edited
        {
            var songsPath = "..\\..\\..\\Songs";
            //songsPath = @"C:\Users\Ethan\Music\";
            //load songs and set listview columns
            if (loadAllSongs)
            {
                Song.initSongList(songsPath);
                LoadArtists();
                LoadAlbums();
            } 

            songsListView.Columns.Clear();
            songsListView.Items.Clear();
            fullList.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);
            foreach (var s in Song.songsList) //add songs to the list view
            {
                songsListView.Items.Add(createSongListViewItem(s));
            }
            foreach (var i in songsListView.Items) //create a copy of the list for searching
            {
                fullList.Add((ListViewItem)i);
            }
        }

        ///////////////////////////////////////////ALBUMS VIEW////////////////////////////////////
        private void LoadAlbums()
        {
            albumList = Song.songsList
                .Select(s => s.album)
                .Distinct()
                .OrderBy(a => a)
                .ToList();
        }

        private void ShowAlbums()
        {
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Album", 300);

            foreach (var album in albumList)
            {
                var listItem = new ListViewItem();
                listItem.Text = album;
                listItem.Tag = album;
                listItem.ImageKey = Song.songsList.Where(s => s.album == album).ToList()[0].id.ToString();
                songsListView.Items.Add(listItem);
            }
        }

        //show songs by a specific album
        private void ShowSongsByAlbum(string album)
        {
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);

            // filters songs by the selected album
            var songsByAlbum = Song.songsList.Where(s => s.album == album).ToList();

            foreach (var s in songsByAlbum)
            {
                songsListView.Items.Add(createSongListViewItem(s));

            }
            viewType = VIEWTYPE.SONG;
        }

        ///////////////////////////////////////////ARTISTS VIEW////////////////////////////////////
        private void LoadArtists()
        {
            if (artistList.Count > 0)
            {
                artistList.Clear();
            }
            artistList = Song.songsList
                .Select(s => s.artist)
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
                listItem.ImageKey = Song.songsList.Where(s => s.artist.Contains(artist)).ToList()[0].id.ToString();
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

        private ListViewItem createSongListViewItem(Song s)
        {
            var listItem = new ListViewItem();
            listItem.Text = s.title;
            listItem.ImageKey = s.id.ToString();
            listItem.SubItems.Add(s.artist);
            listItem.SubItems.Add(s.album);
            listItem.SubItems.Add($"{s.trackNumber} of {s.trackCount}");
            listItem.SubItems.Add(s.year == 0 ? "Not set" : s.year.ToString());
            listItem.Tag = s; //get data from here when clicked or something
            return listItem;
        }

        //////////////////////////////PLAYLIST////////////////////////////
        private void ShowPlaylists()
        {
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Playlist Name", 300);
            songsListView.Columns.Add("Description", 300);

            var playlists = Playlist.getAllPlaylists();
            if (playlists.Count == 0)
            {
                Debug.WriteLine("No playlists to display.");
                return;
            }

            foreach (var playlist in playlists)
            {
                var listItem = new ListViewItem
                {
                    Text = playlist.name,
                    Tag = playlist,
                    ImageKey = "playlist" // Use a default playlist icon
                };
                listItem.SubItems.Add(playlist.description);
                songsListView.Items.Add(listItem);
            }
        }

        private void ShowSongsInPlaylist(Playlist playlist)
        {
            viewType = VIEWTYPE.SONG;
            songsListView.Items.Clear();
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);

            if (playlist.getAllSongs().Count == 0)
            {
                Debug.WriteLine($"Playlist '{playlist.name}' is empty.");
                return;
            }

            foreach (var songId in playlist.getAllSongs())
            {
                var song = Song.songsList.FirstOrDefault(s => s.id == songId);
                if (song != null)
                {
                    var listItem = new ListViewItem
                    {
                        Text = song.title,
                        Tag = song,
                        ImageKey = song.id.ToString()
                    };

                    // Handle artist array safely
                    listItem.SubItems.Add(song.artist != null && song.artist.Length > 0
                        ? string.Join(", ", song.artist)
                        : "Unknown Artist");

                    // Handle album safely
                    listItem.SubItems.Add(!string.IsNullOrEmpty(song.album)
                        ? song.album
                        : "Unknown Album");

                    songsListView.Items.Add(listItem);
                }
            }
        }


        ///////////////////////////////EVENTS/////////////////////////////
        private void addToPlaylistEvent(object sender, EventArgs e)
        {
            var targetSong = (Song)songsListView.SelectedItems[0].Tag;
            var playlist = (Playlist)((ToolStripMenuItem)sender).Tag;

            if (playlist != null && targetSong != null)
            {
                playlist.addSong(targetSong); // Add the song to the playlist
                Playlist.SavePlaylists(); // Save the updated playlist
                Debug.WriteLine($"Song '{targetSong.title}' added to playlist '{playlist.name}'.");
            }
        }

        private void editSongEvent(object sender, EventArgs e)
        {
            var targetSong = (Song)songsListView.SelectedItems[0].Tag;
            var editForm = new SongInfoEditForm(targetSong, SongPlayer.currentSong == targetSong ? true : false);
            editForm.Show();
            Debug.WriteLine($"Open edit form for {targetSong}");
        }

        private void deleteSongEvent(object sender, EventArgs e)
        {
            var targetSong = songsListView.SelectedItems[0].Tag;
            Debug.WriteLine($"Delete song {targetSong}");
        }

        private void listViewClick(object sender, MouseEventArgs e) //for right click actions
        {

            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = songsListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    switch (viewType)
                    {
                        case VIEWTYPE.SONG:
                            showSongContextMenu(focusedItem);
                            break;
                        case VIEWTYPE.ARTIST:
                            break;
                        case VIEWTYPE.PLAYLIST:
                            ShowPlaylistContextMenu(focusedItem);
                            break;
                        case VIEWTYPE.ALBUM:
                            break;

                    }
                {
                }
            }
        }

        private void showSongContextMenu(ListViewItem focusedItem)
        {
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
        }

        private void ShowPlaylistContextMenu(ListViewItem focusedItem)
        {
            var playlistContextMenu = new ContextMenuStrip();

            var deletePlaylist = new ToolStripMenuItem("Delete Playlist");
            deletePlaylist.Click += (s, e) => DeletePlaylist((Playlist)focusedItem.Tag);

            playlistContextMenu.Items.Add(deletePlaylist);

            playlistContextMenu.Show(Cursor.Position);
        }

        private void DeletePlaylist(Playlist playlist)
        {
            var confirm = MessageBox.Show($"Are you sure you want to delete the playlist '{playlist.name}'?",
                                           "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Playlist.getAllPlaylists().Remove(playlist); // Remove the playlist
                Playlist.SavePlaylists(); // Save changes
                ShowPlaylists(); // Refresh the playlist view
                Debug.WriteLine($"Deleted playlist: {playlist.name}");
            }
        }

        private void itemDoubleClick(object sender, EventArgs e)
        {
            switch (viewType)
            {
                case VIEWTYPE.SONG:
                    Song selectedSong = (Song)songsListView.SelectedItems[0].Tag;
                    if (SongPlayer.getStatus() == PlaybackState.Playing) //if switching songs, then do this, otherwise it will automatically play a different song via the songFinishEvent
                    {
                        SongPlayer.skipSongFinishedEvent = true;
                    }
                    SongPlayer.playSong(selectedSong);
                    Debug.WriteLine($"Play song {selectedSong}");
                    break;
                case VIEWTYPE.ARTIST:
                    var selectedArtist = songsListView.SelectedItems[0].Tag.ToString();
                    Debug.WriteLine("Artist was double-clicked: " + selectedArtist);
                    ShowSongsByArtist(selectedArtist);
                    break;
                case VIEWTYPE.PLAYLIST:

                    var selectedPlaylist = (Playlist)songsListView.SelectedItems[0].Tag;
                    Debug.WriteLine("Playlist was double-clicked: " + selectedPlaylist.name);
                    ShowSongsInPlaylist(selectedPlaylist);
                    break;
                case VIEWTYPE.ALBUM:
                    var selectedAlbum = songsListView.SelectedItems[0].Tag.ToString();
                    Debug.WriteLine("Album was double-clicked: " + selectedAlbum);
                    ShowSongsByAlbum(selectedAlbum);
                    break;
            }

        }

        private void searchChanged(object sender, EventArgs e)
        {
            viewType = VIEWTYPE.SONG;
            var query = textSearch.Text.ToLower();
            if (query == "")
            {
                songsListView.Items.Clear();
                songsListView.Items.AddRange(fullList.ToArray());
                return;
            }
            var res = new List<ListViewItem>();
            foreach (ListViewItem item in fullList)
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
            if (viewType != VIEWTYPE.SONG)
            {
                songsListView.Columns.Clear();
                songsListView.Columns.Add("Title", 200);
                songsListView.Columns.Add("Artist", 200);
                songsListView.Columns.Add("Album", 200);
                songsListView.Columns.Add("Track", 70);
                songsListView.Columns.Add("Year", 100);
                songsListView.Items.Clear();
                songsListView.Items.AddRange(fullList.ToArray()); // Restore full song list
                viewType = VIEWTYPE.SONG;
            }
        }

        private void PlaySelectedSong(Song song)
        {
            if (SongPlayer.getStatus() == PlaybackState.Playing)
            {
                SongPlayer.skipSongFinishedEvent = true;
            }
            SongPlayer.playSong(song);
            Debug.WriteLine($"Playing song: {song.title}");
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

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            if (viewType == VIEWTYPE.ALBUM) { return; }
            viewType = VIEWTYPE.ALBUM;
            ShowAlbums();

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (viewType == VIEWTYPE.PLAYLIST) { return; }
            viewType = VIEWTYPE.PLAYLIST;
            ShowPlaylists();
        }
    }
}
