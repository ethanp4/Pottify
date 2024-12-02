using NAudio.Utils;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TagLib.Mpeg;

namespace Pottify
{
    static class SongPlayer
    {
        public static Song currentSong { get; private set; }
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;
        private static Stack<Song> songHistory = new();

        public static PlaybackState getStatus()
        {
            return outputDevice.PlaybackState;
        }

        static SongPlayer()
        {
            outputDevice = new WaveOutEvent(); //this object stays for the life of the application
            outputDevice.PlaybackStopped += songFinishedTask;
        }
        public static bool skipSongFinishedEvent = false; 
        private static void songFinishedTask(object? sender, StoppedEventArgs e)
        {
            if (skipSongFinishedEvent)
            {
                skipSongFinishedEvent = false;
                return;
            }
            Song nextSong;
            switch (SongControls.instance.mode)
            {
                case SongControls.MODE.NORMAL:
                    nextSong = Song.songsList[(currentSong.id+1) % Song.songsList.Count]; //get next song or loop if reached end
                    break;
                case SongControls.MODE.SHUFFLE:
                    nextSong = Song.getRandomSong();
                    break;
                case SongControls.MODE.REPEAT_SONG:
                    nextSong = currentSong;
                    break;
                default:
                    nextSong = Song.getRandomSong();
                    break;
            }
            playSong(nextSong);
        }

      public static void nextSong()
        {
            outputDevice.Stop();
        }
        public static void previousSong()
        {
            var time = outputDevice.GetPositionTimeSpan().Seconds;
            if (time < 3 && songHistory.Count > 1)
            {
                songHistory.Pop();
                playSong(songHistory.Pop());
                Debug.WriteLine($"Went to previous song, history is now {songHistory.Count} items");
            } else
            {
                playSong(currentSong); //restart the song
                Debug.WriteLine("Restarted the song because there was no history or it was < 3 seconds into the song");
            }
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
                    playSong(Song.getRandomSong());
                    Debug.WriteLine("Playing random song");
                    break;
            }
        }

        public static void playSong(Song s) //when a song object is passed, ignore the current state and play that one
        {
            stop();
            var file = s.filePath;
            currentSong = s;

            if (songHistory.TryPeek(out var peeked))
            {
                if (peeked.id != currentSong.id) //push if its unique
                {
                    songHistory.Push(s);
                    Debug.WriteLine($"Added song {s} to history because its not a repeated item, history is now {songHistory.Count} items");
                }
            } else {
                songHistory.Push(s); //or push if its the only item
                Debug.WriteLine($"Added song {s} to history because its the first item, history is now {songHistory.Count} items");
            }

            audioFile = new AudioFileReader(file);
            outputDevice.Init(audioFile);
            outputDevice.Play();
            SongControls.instance.setSongInfo(0, currentSong); //set ui to playing
            DiscordRichPresence.setPresence(s);
        }

        public static void stop()
        {
            outputDevice.Stop();
            if (audioFile != null) { 
               audioFile.Dispose();
            }
            SongControls.instance.setSongInfo(2, null);
        }

        public static decimal getProgress()
        {
            if (outputDevice.PlaybackState != PlaybackState.Playing)
            {
                return 0;
            }
            var progress = outputDevice.GetPositionTimeSpan().TotalMilliseconds;
            progress /= 1000.0;
            progress = audioFile.Position / ((long)audioFile.WaveFormat.AverageBytesPerSecond);
            return (decimal)progress;
        }
        public static void setPosition(long positionInSeconds)
        {
            audioFile.Position = (long)audioFile.WaveFormat.AverageBytesPerSecond * positionInSeconds;
        }
    }
}
