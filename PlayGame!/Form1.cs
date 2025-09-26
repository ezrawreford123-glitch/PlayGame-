using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace PlayGame_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {// these sound players are how the program recognizes to insert the sound
            SoundPlayer startPlayer = new SoundPlayer(Properties.Resources.start);
           
            SoundPlayer gamesoundPlayer = new SoundPlayer(Properties.Resources.gamesound);
            startPlayer.Play();
            countdownLabel.Text = "Game Will Start In: 2";
            Refresh();
            Thread.Sleep(1000);
            countdownLabel.Text = "Game Will Start In: 1";
            Refresh();
            Thread.Sleep(1000);
            gamesoundPlayer.Play();

            goLabel.Text = "GO!";
            Refresh(); 
            Thread.Sleep(500);
         // this will change the background colour to green when the countdown is done
            BackColor = Color.Green;
            startButton.Visible = false;
            countdownLabel.Visible = false;
            goLabel.Visible = true;
           // this will play the sound when the green screen is on
            gamesoundPlayer.Play();
        }  
        
    }
}
