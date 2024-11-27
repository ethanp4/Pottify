using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace Pottify {
    internal class Song {
        public static List<Song> songsList { get; }
        public int id { get; }
        public string title { get; set; }
        public string[] artist { get; set; }
        public string[] genre { get; set; }
        public string album { get; set; }
        public string copyright { get; set; }
        public string comments { get; set; }
        public uint year { get; set; }
        public uint trackCount {get; set; }
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
            var files = Directory.GetFiles(songsPath, "*.mp3");
            foreach (var f in files) {
                new Song(f);
            }
        }

        static Song() {
            songsList = new List<Song>();
        }

        public Song(string path) {
            tfile = TagLib.File.Create(path); //could error if the file is bad
            filePath = path;
            id = songsList.Count;
            title = tfile.Tag.Title;
            artist = tfile.Tag.Performers;
            genre = tfile.Tag.Genres;
            album = tfile.Tag.Album;
            copyright = tfile.Tag.Copyright;
            comments = tfile.Tag.Comment;
            year = tfile.Tag.Year;
            trackNumber = tfile.Tag.Track;
            trackCount = tfile.Tag.TrackCount;
            length = tfile.Properties.Duration;
            picture = tfile.Tag.Pictures[0];

            var icon = new Icon(new MemoryStream(picture.Data.Data));
            images.Images.Add(id.ToString(), icon);
            // Debug.WriteLine($"Added song: {title} {artist[0]} {album} no.{trackNumber}");
            songsList.Add(this);
        }

        public void saveMetadata() {
            tfile.Tag.Title = title;
            tfile.Tag.Performers = artist;
            tfile.Tag.Genres = genre;
            tfile.Tag.Album = album;
            tfile.Tag.Copyright = copyright;
            tfile.Tag.Comment = comments;
            tfile.Tag.Year = year;
            tfile.Tag.Track = trackNumber;
            tfile.Tag.TrackCount = trackCount;
            tfile.Tag.Pictures[0] = picture;
            tfile.Save();
            tfile.Tag.Pictures[0] = picture;
            tfile.Tag.Title = title;
            tfile.Tag.Album = album;
            tfile.Save();
            Debug.WriteLine("Saved song data to file for " + this);
        }
        public override string ToString()
        {
            return $"{title} by {artist[0]}";
        }
    }
}
