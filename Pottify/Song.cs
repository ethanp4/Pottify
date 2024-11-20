using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottify {
    internal class Song {
        public static List<Song> songsList { get; }
        public int id { get; }
        public string title { get; set; }
        public string[] author { get; set; }
        public int length { get; set; } //in seconds
        public string[] genre { get; set; }
        public string filePath { get; } //complete path

        static Song() {
            songsList = new List<Song>();
        }

        public Song(string title, string[] author, int length, string[] genre, string filePath) {
            this.title = title;
            this.author = author;
            this.length = length;
            this.filePath = filePath;
            this.genre = genre;
            songsList.Add(this);
        }
    }
}
