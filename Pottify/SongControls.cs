using NAudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pottify
{
    public partial class SongControls : UserControl
    {
        public static SongControls instance;
        public SongControls()
        {
            InitializeComponent();
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
            switch (status)
            {
                case 0: //playing a song
                    info = $"Playing {song}";
                    btnPlay.Text = "Pause";
                    break;
                case 1: //paused a song
                    info = $"Paused {song}";
                    btnPlay.Text = "Play";
                    break;
                default:
                    info = "No song is playing. Double click a song or press play to play a random song";
                    btnPlay.Text = "Play";
                    break;

            }
            labelInfo.AutoSize = false;
            labelInfo.Text = info;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SongPlayer.stop();
        }

        private void changePlayMode(object sender, EventArgs e)
        {
            if (mode != MODE.SHUFFLE)
            {
                mode = MODE.SHUFFLE;
                btnShuffle.BackColor = Color.RebeccaPurple;
            }
            else
            {
                mode = MODE.NORMAL;
                btnShuffle.BackColor = DefaultBackColor;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
