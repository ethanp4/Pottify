using NAudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            timer.Tick += setProgress;
            timer.Interval = 10;
            timer.Start();
            instance = this;
        }

        public enum MODE { NORMAL, REPEAT_SONG, SHUFFLE }
        public MODE mode { get; private set; } = MODE.NORMAL;

        private void btnPlay_Click(object sender, EventArgs e) //when the song is paused or resumed from the control
        {
            SongPlayer.playSong(); //pause play / play random song -> setSongInfo()
        }

        public void setSongInfo(int status, Song song) //called by SongPlayer
        {
            string info = "";
            string length = "";
            switch (status)
            {
                case 0: //playing a song
                    info = $"Playing {song}";
                    length = $"Song Length: {song.length.TotalSeconds.ToString("F1")} / {song.length.ToString(@"mm\:ss")}";
                    btnPlay.Text = "Pause";
                    break;
                case 1: //paused a song
                    info = $"Paused {song}";
                    length = $"Song Length: {song.length.TotalSeconds.ToString("F1")} / {song.length.ToString(@"mm\:ss")}";
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

        private void songProgressFocus(object sender, EventArgs e)
        {
            switch (((NumericUpDown)sender).Focused)
            {
                case true:
                    Debug.WriteLine("Progress enter focus");
                    timer.Stop();
                    break;
                case false:
                    Debug.WriteLine("Progress exit focus");
                    timer.Start();
                    break;
            }
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
                this.ActiveControl = null;
                timer.Start();
            }
        }
    }
}
