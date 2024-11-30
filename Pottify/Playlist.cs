using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pottify
{
    internal class Playlist
    {
        public int id { get; }
        public string name {  get; set; }
        public string description { get; set; }
        private List<int> songs { get; }
        private static List<Playlist> playlists = new List<Playlist>();
        public Playlist(string name, string description)
        {
            this.name = name;
            this.description = description;
            songs = new();
            Debug.WriteLine($"Made playlist {this}");
            playlists.Add(this);
        }

        public static List<Playlist> getAllPlaylists()
        {
            return playlists;
        }

        public List<int> getAllSongs()
        {
            return songs;
        }

        public void addSong(Song song)
        {
            songs.Add(song.id);
        }
        public override string ToString()
        {
            return name;
        }
    }
}
