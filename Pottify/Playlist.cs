using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Pottify
{
    internal class Playlist
    {
        public int id { get; private set; }
        public string name { get; set; }
        public string description { get; set; }
        private List<int> songs { get; }
        private static List<Playlist> playlists = new List<Playlist>();
        private static string saveFilePath = "playlists.json";

        public Playlist(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.songs = new();
            this.id = playlists.Count > 0 ? playlists[^1].id + 1 : 1; // Incremental ID
            playlists.Add(this);
            Debug.WriteLine($"Created playlist {this}");
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
            if (!songs.Contains(song.id))
            {
                songs.Add(song.id);
            }
        }

        public override string ToString()
        {
            return $"{name} ({songs.Count} songs)";
        }

        // Save playlists to a JSON file
        public static void SavePlaylists()
        {
            try
            {
                var json = JsonSerializer.Serialize(playlists, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveFilePath, json);
                Debug.WriteLine("Playlists saved successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to save playlists: {ex.Message}");
            }
        }

        // Load playlists from a JSON file
        public static void LoadPlaylists()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    var json = File.ReadAllText(saveFilePath);
                    playlists = JsonSerializer.Deserialize<List<Playlist>>(json) ?? new List<Playlist>();
                    Debug.WriteLine("Playlists loaded successfully.");
                }
                else
                {
                    Debug.WriteLine("No playlist file found. Starting with an empty list.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to load playlists: {ex.Message}");
            }
        }
    }
}
