using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Pottify
{
    public partial class SongControls : UserControl
    {
        public static SongControls instance;
        private static Timer timer;
        public SongControls()
        {
            InitializeComponent();
            timer = new();
            timer.Tick += setProgress; //constantly read progress from SongPlayer
            timer.Interval = 100;
            timer.Start();
            instance = this;

            tooltipSongProgressHelp.SetToolTip(numProgress, "Click the timer to edit it, hit enter to set, or esc to cancel");
            volumeSlider1.VolumeChanged += VolumeSlider1_VolumeChanged;
        }

        private void VolumeSlider1_VolumeChanged(object? sender, EventArgs e)
        {
            SongPlayer.setVolume(volumeSlider1.Volume);
        }

        public enum MODE { NORMAL, REPEAT_SONG, SHUFFLE }
        public MODE mode { get; private set; } = MODE.NORMAL;

        private void btnPlay_Click(object sender, EventArgs e) //when the song is paused or resumed from the control
        {
            SongPlayer.playSong(); //pause / play / play random song -> setSongInfo()
        }

        public void setSongInfo(int status, Song song) //called by SongPlayer
        {
            string info = "";
            string length = "";
            switch (status)
            {
                case 0: //playing a song
                    info = $"Playing {song}";
                    length = $"{song.length.TotalSeconds.ToString("F1")} / {song.length.ToString(@"mm\:ss")}";
                    btnPlay.Text = "Pause";
                    break;
                case 1: //paused a song
                    info = $"Paused {song}";
                    length = $"{song.length.TotalSeconds.ToString("F1")} / {song.length.ToString(@"mm\:ss")}";
                    btnPlay.Text = "Play";
                    break;
                default:
                    info = "No song is playing. Double click a song or press play to play a random song";
                    length = "I dont know!";
                    btnPlay.Text = "Play";
                    break;

            }
            labelInfo.AutoSize = false;
            labelInfo.Text = info;
            labelLength.Text = length;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SongPlayer.skipSongFinishedEvent = true;
            SongPlayer.stop();
        }

        private void changePlayMode(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Shuffle":
                    if (mode != MODE.SHUFFLE)
                    {
                        mode = MODE.SHUFFLE;
                        buttonLoop.BackColor = DefaultBackColor;
                        btnShuffle.BackColor = Color.MediumSeaGreen;
                    }
                    else if (mode == MODE.SHUFFLE)
                    {
                        mode = MODE.NORMAL;
                        btnShuffle.BackColor = DefaultBackColor;
                    }
                    break;
                case "Loop":
                    if (mode != MODE.REPEAT_SONG)
                    {
                        mode = MODE.REPEAT_SONG;
                        buttonLoop.BackColor = Color.MediumSeaGreen;
                        btnShuffle.BackColor = DefaultBackColor;
                    }
                    else if (mode == MODE.REPEAT_SONG)
                    {
                        mode = MODE.NORMAL;
                        buttonLoop.BackColor = DefaultBackColor;
                    }
                    break;
            }
            Debug.WriteLine($"Mode is set to {mode}");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SongPlayer.skipSongFinishedEvent = true;
            SongPlayer.previousSong();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //SongPlayer.intentionalSongChange = true;
            SongPlayer.nextSong();
        }

        private void songProgressClicked(object sender, EventArgs e)
        {
            timer.Stop();
        }

        public void setProgress(object sender, EventArgs e)
        {
            numProgress.Value = Convert.ToDecimal(SongPlayer.getProgress());
        }

        private void songProgressKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SongPlayer.setPosition((long)numProgress.Value);
                timer.Start();
            }
            if (e.KeyCode == Keys.Escape)
            {
                timer.Start();
            }
        }
    }
}
