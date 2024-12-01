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

        public bool playing = false;


        public void setPlaying() //set controls state
        {
            playing = true;
            btnPlay.Text = "Pause";
        }

        public void setStopped()//set controls state
        {
            playing = false;
            btnPlay.Text = "Play";
        }

        private void btnPlay_Click(object sender, EventArgs e) //when the song is paused or resumed from the control
        {
            SongPlayer.playSong(); //pause play / play random song
        }

        public void setSongInfo(int status, Song song) {
            string info = "No song is playing";
            switch (status)
            {
                case 0: //playing a song
                    info = $"Playing {song}";
                    break;
                case 1: //paused a song
                    info = $"Paused {song}";
                    break;
            }
            labelInfo.AutoSize = false;
            labelInfo.Text = info;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
