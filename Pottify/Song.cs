using System.Diagnostics;
using System.Runtime.CompilerServices;
using TagLib;

namespace Pottify
{
    public class Song
    {
        public static List<Song> songsList { get; }
        public int id { get; }
        public string title { get; set; }
        public string artist { get; set; }
        public string genre { get; set; }
        public string album { get; set; }
        public string copyright { get; set; }
        public string comments { get; set; }
        public uint year { get; set; }
        public uint trackCount { get; set; }
        public uint trackNumber { get; set; }
        public TimeSpan length { get; } //in seconds
        public IPicture picture { get; set; }
        public static ImageList images = new();
        private TagLib.File tfile;
        public string filePath { get; } //complete path

        //song is loaded and taglib file is also created
        //when changes want to be made, the properties are adjusted
        //then song.saveMetadata() must be run to write the actual changes to the file
        //the taglib file variable isnt publically accessible
        public static void initSongList(string songsPath)
        {
            if (songsList.Count > 0) //clear if reinitializing
            {
                foreach (var s in songsList)
                {
                    s.tfile.Dispose();
                }
                songsList.Clear();

            }
            var files = Directory.GetFiles(songsPath, "*.mp3");
            foreach (var f in files)
            {
                new Song(f);
            }
        }

        static Song()
        {
            songsList = new List<Song>();
        }

        public Song(string path)
        {
            tfile = TagLib.File.Create(path); //could error if the file is bad
            filePath = path;
            id = songsList.Count;
            title = tfile.Tag.Title ?? "No title";
            artist = tfile.Tag.FirstPerformer ?? "No artist set";
            genre = tfile.Tag.FirstGenre ?? "No genre set";
            album = tfile.Tag.Album ?? "No album set";
            copyright = tfile.Tag.Copyright;
            comments = tfile.Tag.Comment;
            year = tfile.Tag.Year;
            trackNumber = tfile.Tag.Track;
            trackCount = tfile.Tag.TrackCount;
            length = tfile.Properties.Duration;

            Bitmap bmp;
            if (tfile.Tag.Pictures.Length == 0) //make blank picture if the file doesnt have one
            {
                bmp = new Bitmap(256, 256);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, 256, 256);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }
            } else
            {
                picture = tfile.Tag.Pictures[0];
                var ms = new MemoryStream(picture.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                bmp = new Bitmap(ms);
                ms.Dispose();
            }
            images.Images.Add(id.ToString(), bmp);

            // Debug.WriteLine($"Added song: {title} {artist[0]} {album} no.{trackNumber}");
            songsList.Add(this);
        }

        public static Song getRandomSong()
        {
            var song = Song.songsList[new Random().Next(Song.songsList.Count)];
            return song;
        }

        public Bitmap getImageAsBitmap()
        {
            //var ms = new MemoryStream(picture.Data.Data);
            //ms.Seek(0, SeekOrigin.Begin);
            //var bmp = new Bitmap(ms);
            //ms.Dispose();
            return new Bitmap(images.Images[this.id]);
        }

        public void saveMetadata()
        {
            tfile.Tag.Title = title;
            tfile.Tag.Performers = new string[] { artist };
            tfile.Tag.Genres = new string[] { genre };
            tfile.Tag.Album = album;
            tfile.Tag.Copyright = copyright;
            tfile.Tag.Comment = comments;
            tfile.Tag.Year = year;
            tfile.Tag.Track = trackNumber;
            tfile.Tag.TrackCount = trackCount;
            //tfile.Tag.Pictures[0] = picture;
            tfile.Save();
            Debug.WriteLine("Saved song data to file for " + this);
        }

        public Song getSongById(int id)
        {
            return songsList[id];
        }
        public override string ToString()
        {
            return $"{title} by {artist}";
        }
    }
}
