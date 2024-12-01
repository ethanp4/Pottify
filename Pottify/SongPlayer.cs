using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pottify
{
    static class SongPlayer
    {
        public static Song currentSong { get; private set; }
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;

        static SongPlayer()
        {
            outputDevice = new WaveOutEvent(); //this object stays for the life of the application
            //outputDevice.PlaybackStopped += stopSong;
        }

        public static void playSong() //when no song object is passed then choose the best option depending on the state
        {
            switch (outputDevice.PlaybackState)
            {
                case PlaybackState.Playing: //if playing then pause
                    outputDevice.Pause();
                    SongControls.instance.setSongInfo(1, currentSong);
                    Debug.WriteLine($"Pausing song {currentSong}");
                    break;
                case PlaybackState.Paused: //if paused then play
                    outputDevice.Play();
                    SongControls.instance.setSongInfo(0, currentSong);
                    Debug.WriteLine($"Resuming song {currentSong}");
                    break;
                case PlaybackState.Stopped: //if theres nothing then play a random song
                    var song = Song.songsList[new Random().Next(Song.songsList.Count)];
                    playSong(song);
                    Debug.WriteLine("Playing random song");
                    break;
            }
        }

        public static void playSong(Song s) //when a song object is passed, ignore the current state and play that one
        {
            stop();
            var file = s.filePath;
            currentSong = s;
            audioFile = new AudioFileReader(file);
            outputDevice.Init(audioFile);
            outputDevice.Play();
            SongControls.instance.setSongInfo(0, currentSong); //set ui to playing
        }

        public static void stop()
        {
            outputDevice.Stop();
            if (audioFile != null) { 
               audioFile.Dispose();
            }
            SongControls.instance.setSongInfo(2, null);
        }

        //public static void pauseSong()
        //{
        //    outputDevice.Pause();
        //    SongControls.instance.setStopped();
        //}

        //public static void stopSong(object? sender, StoppedEventArgs e) {
        //    outputDevice.Stop();
        //    SongControls.instance.setStopped();
        //}
    }
}
