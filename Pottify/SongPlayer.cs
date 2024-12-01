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

        public static PlaybackState getStatus()
        {
            return outputDevice.PlaybackState;
        }

        static SongPlayer()
        {
            outputDevice = new WaveOutEvent(); //this object stays for the life of the application
            outputDevice.PlaybackStopped += songFinishedTask;
        }
        public static bool ignoreNextSongFinishEvent = false;
        private static void songFinishedTask(object? sender, StoppedEventArgs e)
        {
            if (ignoreNextSongFinishEvent)
            {
                ignoreNextSongFinishEvent = false;
                return;
            }
            Song nextSong;
            switch (SongControls.instance.mode)
            {
                case SongControls.MODE.NORMAL:
                    nextSong = Song.songsList[currentSong.id+1 % Song.songsList.Count]; //get next song or loop if reached end
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
    }
}
