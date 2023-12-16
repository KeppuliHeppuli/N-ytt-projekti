using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Näyttöprojekti
{
    public partial class Breakout : Form
    {
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd = new Random();

        public Breakout()
        {
            InitializeComponent();
        }

        private void setupGame()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;
            gameTimer.Start();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }
        private void Breakout_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameMenu form3 = new GameMenu();
            form3.Show();

            if (e.Cancel)
            {
                return;
            }
        }
    }
}
