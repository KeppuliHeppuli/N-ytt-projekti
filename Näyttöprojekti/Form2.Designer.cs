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
            this.playerPaddlePB = new System.Windows.Forms.PictureBox();
            this.cpuPaddlePB = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ballPanel = new System.Windows.Forms.Panel();
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddlePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddlePB)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPaddlePB
            // 
            this.playerPaddlePB.BackColor = System.Drawing.Color.Red;
            this.playerPaddlePB.Location = new System.Drawing.Point(0, 201);
            this.playerPaddlePB.Name = "playerPaddlePB";
            this.playerPaddlePB.Size = new System.Drawing.Size(92, 20);
            this.playerPaddlePB.TabIndex = 0;
            this.playerPaddlePB.TabStop = false;
            this.playerPaddlePB.Click += new System.EventHandler(this.playerPaddlePB_Click);
            // 
            // cpuPaddlePB
            // 
            this.cpuPaddlePB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cpuPaddlePB.Location = new System.Drawing.Point(707, 201);
            this.cpuPaddlePB.Name = "cpuPaddlePB";
            this.cpuPaddlePB.Size = new System.Drawing.Size(92, 20);
            this.cpuPaddlePB.TabIndex = 1;
            this.cpuPaddlePB.TabStop = false;
            this.cpuPaddlePB.Click += new System.EventHandler(this.cpuPaddlePB_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ballPanel
            // 
            this.ballPanel.BackColor = System.Drawing.Color.White;
            this.ballPanel.Location = new System.Drawing.Point(373, 182);
            this.ballPanel.Name = "ballPanel";
            this.ballPanel.Size = new System.Drawing.Size(20, 20);
            this.ballPanel.TabIndex = 2;
            this.ballPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ballPanel_Paint);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Red;
            this.playerScore.Location = new System.Drawing.Point(96, 23);
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
            this.cpuScore.Location = new System.Drawing.Point(677, 23);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(32, 22);
            this.cpuScore.TabIndex = 4;
            this.cpuScore.Text = "00";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.ballPanel);
            this.Controls.Add(this.cpuPaddlePB);
            this.Controls.Add(this.playerPaddlePB);
            this.Name = "Pong";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pong_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pong_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddlePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddlePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPaddlePB;
        private System.Windows.Forms.PictureBox cpuPaddlePB;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel ballPanel;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
    }
}