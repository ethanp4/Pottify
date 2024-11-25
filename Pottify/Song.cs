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
        public DateTime date { get; set; }
        public uint trackNumber { get; set; }
        public TimeSpan length { get; set; } //in seconds
        public IPicture picture { get; set; }
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
            date = tfile.Tag.DateTagged ?? DateTime.MinValue;
            trackNumber = tfile.Tag.Track;
            length = tfile.Properties.Duration;
            picture = tfile.Tag.Pictures[0];
            Debug.WriteLine($"Added song: {title} {artist[0]} {album} no.{trackNumber}");
            songsList.Add(this);
        }
    }
}
