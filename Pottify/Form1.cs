using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Pottify
{
    public partial class Form1 : Form
    {
        private List<ListViewItem> fullList = new();
        private List<string> artistList = new(); // Stores the list of unique artists

        public Form1()
        {
            InitializeComponent();
            //https://github.com/mono/taglib-sharp

            var songsPath = "..\\..\\..\\Songs";
            // songsPath = @"C:\Users\Ethan\Music\";

            //load songs and set listview columns
            Song.initSongList(songsPath);
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

            // Set autocomplete source
            var songs = new AutoCompleteStringCollection();
            foreach (var title in Song.songsList.Select(s => s.title))
            {
                songs.Add(title);
            }
            textSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;

            // load artists into the artistList
            LoadArtists(); 
        }
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

            songsListView.MouseDoubleClick -= songDoubleClick;
            songsListView.MouseDoubleClick += artistDoubleClick; 
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
                var listItem = new ListViewItem();
                listItem.Text = s.title;
                listItem.SubItems.Add(s.artist[0]); // Assuming the first artist is displayed
                listItem.SubItems.Add(s.album);
                listItem.SubItems.Add($"{s.trackNumber} of {s.trackCount}");
                listItem.SubItems.Add(s.year == 0 ? "Not set" : s.year.ToString());
                listItem.Tag = s; // Store song object in Tag
                songsListView.Items.Add(listItem);
            }

           
            songsListView.MouseDoubleClick -= artistDoubleClick;
            songsListView.MouseDoubleClick += songDoubleClick;
        }

        private void songDoubleClick(object sender, EventArgs e)
        {
            Song selectedSong = (Song)songsListView.SelectedItems[0].Tag;
            Debug.WriteLine("song was double clicked: " + selectedSong);
        }

        private void artistDoubleClick(object sender, EventArgs e)
        {
            var selectedArtist = songsListView.SelectedItems[0].Tag.ToString();
            Debug.WriteLine("artist was double clicked: " + selectedArtist);

            ShowSongsByArtist(selectedArtist); 
        }

        // searching for now
        private void searchChanged(object sender, EventArgs e)
        {
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

        
        private void btnAll_Click(object sender, EventArgs e)
        {
            songsListView.Items.Clear();
            songsListView.Items.AddRange(fullList.ToArray()); // Restore full song list
            songsListView.Columns.Clear();
            songsListView.Columns.Add("Title", 200);
            songsListView.Columns.Add("Artist", 200);
            songsListView.Columns.Add("Album", 200);
            songsListView.Columns.Add("Track", 70);
            songsListView.Columns.Add("Year", 100);

            songsListView.MouseDoubleClick -= artistDoubleClick;
            songsListView.MouseDoubleClick += songDoubleClick;
        }

        //Event handler for "Artists" button
        private void btnArtists_Click_1(object sender, EventArgs e)
        {
            ShowArtists();
            songsListView.View = View.LargeIcon;
        }

       
    }
}