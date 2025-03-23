namespace game
{
    partial class Form2
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
            this.lblUserPlayer = new System.Windows.Forms.Label();
            this.lblCompPlayer = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCompChoice = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblCompPlayerScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerScorenum = new System.Windows.Forms.Label();
            this.lblScoreCPU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserPlayer
            // 
            this.lblUserPlayer.AutoSize = true;
            this.lblUserPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPlayer.Location = new System.Drawing.Point(96, 107);
            this.lblUserPlayer.Name = "lblUserPlayer";
            this.lblUserPlayer.Size = new System.Drawing.Size(58, 20);
            this.lblUserPlayer.TabIndex = 0;
            this.lblUserPlayer.Text = "Player";
            this.lblUserPlayer.Click += new System.EventHandler(this.lblUserPlayer_Click);
            // 
            // lblCompPlayer
            // 
            this.lblCompPlayer.AutoSize = true;
            this.lblCompPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPlayer.Location = new System.Drawing.Point(292, 107);
            this.lblCompPlayer.Name = "lblCompPlayer";
            this.lblCompPlayer.Size = new System.Drawing.Size(141, 20);
            this.lblCompPlayer.TabIndex = 1;
            this.lblCompPlayer.Text = "Computer Player";
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(88, 151);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "ROCK";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(88, 180);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Text = "PAPER";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(88, 209);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 4;
            this.btnScissor.Text = "SCISSOR";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(71, 284);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(140, 24);
            this.lblChoice.TabIndex = 5;
            this.lblChoice.Text = "Player Choice";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(220, 348);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCompChoice
            // 
            this.lblCompChoice.AutoSize = true;
            this.lblCompChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompChoice.Location = new System.Drawing.Point(270, 284);
            this.lblCompChoice.Name = "lblCompChoice";
            this.lblCompChoice.Size = new System.Drawing.Size(173, 24);
            this.lblCompChoice.TabIndex = 7;
            this.lblCompChoice.Text = "Computer Choice";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(12, 34);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(36, 13);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Text = "Player";
            // 
            // lblCompPlayerScore
            // 
            this.lblCompPlayerScore.AutoSize = true;
            this.lblCompPlayerScore.Location = new System.Drawing.Point(12, 59);
            this.lblCompPlayerScore.Name = "lblCompPlayerScore";
            this.lblCompPlayerScore.Size = new System.Drawing.Size(84, 13);
            this.lblCompPlayerScore.TabIndex = 9;
            this.lblCompPlayerScore.Text = "Computer Player";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(128, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score";
            // 
            // lblPlayerScorenum
            // 
            this.lblPlayerScorenum.AutoSize = true;
            this.lblPlayerScorenum.Location = new System.Drawing.Point(141, 34);
            this.lblPlayerScorenum.Name = "lblPlayerScorenum";
            this.lblPlayerScorenum.Size = new System.Drawing.Size(13, 13);
            this.lblPlayerScorenum.TabIndex = 11;
            this.lblPlayerScorenum.Text = "0";
            // 
            // lblScoreCPU
            // 
            this.lblScoreCPU.AutoSize = true;
            this.lblScoreCPU.Location = new System.Drawing.Point(141, 59);
            this.lblScoreCPU.Name = "lblScoreCPU";
            this.lblScoreCPU.Size = new System.Drawing.Size(13, 13);
            this.lblScoreCPU.TabIndex = 12;
            this.lblScoreCPU.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.lblScoreCPU);
            this.Controls.Add(this.lblPlayerScorenum);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCompPlayerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblCompChoice);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblCompPlayer);
            this.Controls.Add(this.lblUserPlayer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserPlayer;
        private System.Windows.Forms.Label lblCompPlayer;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCompChoice;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblCompPlayerScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerScorenum;
        private System.Windows.Forms.Label lblScoreCPU;
    }
}