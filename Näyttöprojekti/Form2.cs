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

        public Pong()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

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

        private void Pong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cpuPaddlePB_Click(object sender, EventArgs e)
        {
            this.cpuPaddlePB.BackColor = System.Drawing.Color.Red;
            this.cpuPaddlePB.Location = new System.Drawing.Point(364, 150);
            this.cpuPaddlePB.Size = new System.Drawing.Size(10, 60);
            this.cpuPaddlePB.TabIndex = 1;
            this.cpuPaddlePB.TabStop = false;
        }

        private void playerPaddlePB_Click(object sender, EventArgs e)
        {
            this.playerPaddlePB.BackColor = System.Drawing.Color.Blue;
            this.playerPaddlePB.Location = new System.Drawing.Point(12, 150);
            this.playerPaddlePB.Size = new System.Drawing.Size(10, 60);
            this.playerPaddlePB.TabIndex = 1;
            this.playerPaddlePB.TabStop = false;
        }

        private void ballPB_Click(object sender, EventArgs e)
        {

        }

        private void ballPanel_Paint(object sender, PaintEventArgs e)
        {
            this.ballPanel.BackColor = System.Drawing.Color.White;
            this.ballPanel.Location = new System.Drawing.Point(190, 190);
            this.ballPanel.Size = new System.Drawing.Size(20, 20);
            this.ballPanel.TabIndex = 2;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
        }

    }
}
