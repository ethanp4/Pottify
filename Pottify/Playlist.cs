using System;
using System.Collections.Generic;
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
        public List<Song> songs { get; }
        public static List<Playlist> playlists = new List<Playlist>();
        public Playlist(string name, string description)
        {
            this.name = name;
            this.description = description;
            songs = new();
            playlists.Add(this);
        }
    }
}
