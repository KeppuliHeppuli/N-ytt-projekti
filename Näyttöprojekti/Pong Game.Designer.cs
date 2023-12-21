namespace Näyttöprojekti
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerPaddle = new System.Windows.Forms.PictureBox();
            this.cpuPaddle = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerWins = new System.Windows.Forms.Label();
            this.cpuWins = new System.Windows.Forms.Label();
            this.playerWinsLB = new System.Windows.Forms.Label();
            this.cpuWinsLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPaddle
            // 
            this.playerPaddle.BackColor = System.Drawing.Color.Red;
            this.playerPaddle.Location = new System.Drawing.Point(12, 186);
            this.playerPaddle.Name = "playerPaddle";
            this.playerPaddle.Size = new System.Drawing.Size(27, 127);
            this.playerPaddle.TabIndex = 0;
            this.playerPaddle.TabStop = false;
            this.playerPaddle.Click += new System.EventHandler(this.playerPaddlePB_Click);
            // 
            // cpuPaddle
            // 
            this.cpuPaddle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cpuPaddle.Location = new System.Drawing.Point(897, 230);
            this.cpuPaddle.Name = "cpuPaddle";
            this.cpuPaddle.Size = new System.Drawing.Size(27, 127);
            this.cpuPaddle.TabIndex = 1;
            this.cpuPaddle.TabStop = false;
            this.cpuPaddle.Click += new System.EventHandler(this.cpuPaddlePB_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Red;
            this.playerScore.Location = new System.Drawing.Point(322, 7);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(32, 22);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScore.ForeColor = System.Drawing.Color.Blue;
            this.cpuScore.Location = new System.Drawing.Point(498, 9);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(32, 22);
            this.cpuScore.TabIndex = 4;
            this.cpuScore.Text = "00";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 5;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // playerWins
            // 
            this.playerWins.AutoSize = true;
            this.playerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWins.ForeColor = System.Drawing.Color.Red;
            this.playerWins.Location = new System.Drawing.Point(96, 9);
            this.playerWins.Name = "playerWins";
            this.playerWins.Size = new System.Drawing.Size(32, 22);
            this.playerWins.TabIndex = 6;
            this.playerWins.Text = "00";
            // 
            // cpuWins
            // 
            this.cpuWins.AutoSize = true;
            this.cpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuWins.ForeColor = System.Drawing.Color.Blue;
            this.cpuWins.Location = new System.Drawing.Point(820, 7);
            this.cpuWins.Name = "cpuWins";
            this.cpuWins.Size = new System.Drawing.Size(32, 22);
            this.cpuWins.TabIndex = 7;
            this.cpuWins.Text = "00";
            // 
            // playerWinsLB
            // 
            this.playerWinsLB.AutoSize = true;
            this.playerWinsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWinsLB.ForeColor = System.Drawing.Color.Red;
            this.playerWinsLB.Location = new System.Drawing.Point(-1, 9);
            this.playerWinsLB.Name = "playerWinsLB";
            this.playerWinsLB.Size = new System.Drawing.Size(91, 20);
            this.playerWinsLB.TabIndex = 8;
            this.playerWinsLB.Text = "Player wins:";
            // 
            // cpuWinsLB
            // 
            this.cpuWinsLB.AutoSize = true;
            this.cpuWinsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuWinsLB.ForeColor = System.Drawing.Color.Blue;
            this.cpuWinsLB.Location = new System.Drawing.Point(733, 9);
            this.cpuWinsLB.Name = "cpuWinsLB";
            this.cpuWinsLB.Size = new System.Drawing.Size(81, 20);
            this.cpuWinsLB.TabIndex = 9;
            this.cpuWinsLB.Text = "CPU wins:";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuWinsLB);
            this.Controls.Add(this.playerWinsLB);
            this.Controls.Add(this.cpuWins);
            this.Controls.Add(this.playerWins);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpuPaddle);
            this.Controls.Add(this.playerPaddle);
            this.Name = "Pong";
            this.Text = "Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pong_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pong_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPaddle;
        private System.Windows.Forms.PictureBox cpuPaddle;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label playerWins;
        private System.Windows.Forms.Label cpuWins;
        private System.Windows.Forms.Label playerWinsLB;
        private System.Windows.Forms.Label cpuWinsLB;
    }
}