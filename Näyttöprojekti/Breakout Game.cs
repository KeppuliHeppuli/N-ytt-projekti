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

        PictureBox[] blockArray;

        public Breakout()
        {
            InitializeComponent();
            PlaceBlocks();
        }
        private void gameEnd()
        {
            DialogResult result = MessageBox.Show("Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                removeBlocks();
                PlaceBlocks();
                gameTimer.Start();
            }
            else if (result == DialogResult.No)
            {
               
                this.Close();
            }
        }

        private void ResetKeyState()
        {
            goLeft = false;
            goRight = false;
        }

        private void setupGame()
        {
            isGameOver = false;
            ResetKeyState();
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;

            txtScore.Text = "Score: " + score;
            gameTimer.Start();

            ballPB.Left = 376;
            ballPB.Top = 328;
            playerPB.Left = 347;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }
        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            txtScore.Text = "Score: " + score + " " + message;
        }
        private void PlaceBlocks()
        {
            blockArray = new PictureBox[15];

            int a = 0;

            int top = 50;
            int left = 100;

            for (int i=0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;

                if (a == 5)
                {
                    top = top + 50;
                    left = 100;
                    a = 0;
                }
                if (a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left += 100;
                }
            }

            setupGame();

        }
        private void removeBlocks()
        {
            foreach(PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            if (goLeft == true && playerPB.Left > 0)
            {
                playerPB.Left -= playerSpeed;
            }
            if (goRight == true && playerPB.Left <700)
            {
                playerPB.Left += playerSpeed;
            }

            ballPB.Left += ballx;
            ballPB.Top += bally;

            if (ballPB.Left < 0 || ballPB.Left > 775)
            {
                ballx = -ballx;
            }

            if (ballPB.Top < 0)
            {
                bally = -bally;
            }

            if (ballPB.Bounds.IntersectsWith(playerPB.Bounds)) //logiikka sille, jos pallo osuu pelaajaan 
            {                                                  // sitten se pongahtaa muualle
                ballPB.Top = playerPB.Top - ballPB.Height;
                bally = -bally;
                
            }
            
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ballPB.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        bally = -bally;

                        this.Controls.Remove(x);
                    }
                }
            }



            if (score == 34)
            {
                gameTimer.Stop();
                gameEnd();
                gameOver("You win! Press Enter to play again.");

            }
            if (ballPB.Top > 580)
            {
                gameTimer.Stop();
                gameEnd();
                gameOver("You lose! Press Enter to play again.");
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlaceBlocks();
            }
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

        private void Breakout_Load(object sender, EventArgs e)
        {

        }
    }
}
