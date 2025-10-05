using NAudio.Utils;
using NAudio.Wave;
using System.Diagnostics;

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
        private static void songFinishedTask(object? sender, StoppedEventArgs e) //this function is for when a song naturally finishes (no user input)
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
                    nextSong = Song.songsList[(currentSong.id + 1) % Song.songsList.Count]; //get next song or loop if reached end
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
            }
            else
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
            }
            else
            {
                songHistory.Push(s); //or push if its the only item
                Debug.WriteLine($"Added song {s} to history because its the first item, history is now {songHistory.Count} items");
            }

            audioFile = new AudioFileReader(file);
            outputDevice.Init(audioFile);
            outputDevice.Play();
            SongControls.instance.setSongInfo(0, currentSong); //set ui to playing
        }

        public static void stop()
        {
            outputDevice.Stop();
            if (audioFile != null)
            {
                audioFile.Dispose();
            }
            SongControls.instance.setSongInfo(2, null);
        }

        public static double getProgress()
        {
            if (outputDevice.PlaybackState == PlaybackState.Stopped)
            {
                return 0;
            }
            var progress = (double)audioFile.Position / ((double)audioFile.WaveFormat.AverageBytesPerSecond);
            //Debug.WriteLine($"Position is {audioFile.Position}");
            //Debug.WriteLine($"Progress is {progress}");
            return progress;
        }

        public static void setPosition(double positionInSeconds)
        {
            audioFile.Position = Convert.ToInt64(((double)audioFile.WaveFormat.AverageBytesPerSecond) * positionInSeconds);
        }

        public static void setVolume(float volume)
        {
            outputDevice.Volume = volume;
        }
    }
}
