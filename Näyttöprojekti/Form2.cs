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
    public partial class Pong : Form
    {
        private const int initialBallLeft = 434;
        private const int initialBallTop = 239;
        private const int initialBallSpeedX = 5; 
        private const int initialBallSpeedY = 5; 
        bool goup;
        bool godown;
        int speed = 5;                                                                                                                                                                                                                   
        int ballx = 5;
        int bally=5;
        int score = 0;
        int cpupoint = 0;
        int wins = 0;
        int cpuwins = 0;
        
        public Pong()
        {
            InitializeComponent();
        
        }
        private void ResetGame()
        {
            if (score == 10)
            {
                cpuwins++;
            }
            else
            {
                wins++;
            }
           
            score = 0;
            cpupoint = 0;
            ball.Left = initialBallLeft; 
            ball.Top = initialBallTop;   
            ballx = initialBallSpeedX;   
            bally = initialBallSpeedY;  


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
           
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }



        private void Pong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cpuPaddlePB_Click(object sender, EventArgs e)
        {

        }

        private void playerPaddlePB_Click(object sender, EventArgs e)
        {

        }

        private void ballPB_Click(object sender, EventArgs e)
        {

        }

        private void ballPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
          
                playerScore.Text = "" + score;
                cpuScore.Text = "" + cpupoint;
                playerWins.Text = "" + wins;
                cpuWins.Text = "" + cpuwins;

                ball.Top -= bally;
                ball.Left -= ballx;

                cpuPaddle.Top += speed;


                if (score < 5)
                {
                    if (cpuPaddle.Top < 0 || cpuPaddle.Top > 455)
                    {
                        speed = -speed;
                    }
                }
                else
                {                                    //Jos pisteet on suurempi kuin 5
                    cpuPaddle.Top = ball.Top + 30;   // tekee pelistä vaikeamman antamalla
                }                                    // TK nopeammin yrittää ampua pallo takaisin




                if (ball.Left < 0)            //Tarkistaa onko pallo mennyt pelaajan "maaliin" 
                {
                    ball.Left = 434;  //resetoi pallon keskelle kenttää
                    ballx = -ballx;    //vaihtaa pallon suunnan
                    ballx -= 2;         // nostaa pallon nopeautta
                    cpupoint++;          // lisää TK pisteitä
                }

                if (ball.Left + ball.Width > ClientSize.Width)
                {
                    ball.Left = 434; //resetoi pallon keskelle kenttää
                    ballx = -ballx;  //vaihtaa pallon suunnan
                    ballx += 2;      //nostaa nopeutta
                    score++;         //lisää pelaajan pisteitä
                }

                //pallon ohjaus
                //jos pallo koskee näytön ylä tai alaosaa
                if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
                {
                    bally = -bally; // Lyö pallon takaisin että se pysyy näytöllä
                }
                //jos pallo osuu pelaajaan tai tk mailaan
                if (ball.Bounds.IntersectsWith(playerPaddle.Bounds) || ball.Bounds.IntersectsWith(cpuPaddle.Bounds))
                {
                    ballx = -ballx; //lyö pallon takaisin
                }

                //pelaajan ohjaus

                //jos goup on true niin pelaaja on pelin ylärajan sisäpuolella
                if (goup == true && playerPaddle.Top > 0)
                {
                    playerPaddle.Top -= 8; //liikuttaa pelaajaa ylöspäin
                }

                if (godown == true && playerPaddle.Top < 455)
                {
                    playerPaddle.Top += 8; //liikuttaa pelajaa alaspäin
                }

                if (score > 10 || cpupoint > 10)
           {
                gameTimer.Stop();

                DialogResult result = MessageBox.Show("Haluatko aloittaa uuden pelin?", "Peli päättyi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ResetGame();
                    gameTimer.Start();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                   
                }
            }
                
            

        }

        private void Pong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pelivalikko form2 = new Pelivalikko();
            form2.Show();

            if (e.Cancel)
            {

                return;

            }

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
