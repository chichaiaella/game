using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form2: Form
    {
        
        
        public string name { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        
            public int UserScore = 0;
            public int CompScore = 0;

        

        public void button2_Click(object sender, EventArgs e)
        {
          
            lblChoice.Text = "Paper";
        }

        private void lblUserPlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            int choice = ran.Next(4);
            if(choice == 1)
            {
                lblCompChoice.Text = "Rock";
                if (lblChoice.Text == "Rock")
                {
                    MessageBox.Show("tie");
                }
                else if(lblChoice.Text == "Paper")
                {
                    UserScore++;
                    lblPlayerScorenum.Text = UserScore.ToString();
                    MessageBox.Show("Win");
                    
                }
                else if (lblChoice.Text == "Scissor")
                {
                    CompScore++;
                    lblScoreCPU.Text = CompScore.ToString();
                    MessageBox.Show("Lose");
                    
                }

            }
            else if (choice == 2)
            {
                lblCompChoice.Text = "Paper";
                if (lblChoice.Text == "Paper")
                {
                    MessageBox.Show("tie");
                }
                else if (lblChoice.Text == "Scissor")
                {
                    UserScore++;
                    lblPlayerScorenum.Text = UserScore.ToString();
                    MessageBox.Show("Win");
                    
                }
                else if (lblChoice.Text == "Rock")
                {
                    CompScore++;
                    lblScoreCPU.Text = CompScore.ToString();
                    MessageBox.Show("Lose");
                    
                }

            }
            else if (choice == 3)
            {
                lblCompChoice.Text = "Scissor";
                if (lblChoice.Text == "Scissor")
                {
                    MessageBox.Show("tie");
                }
                else if (lblChoice.Text == "Rock")
                {
                    UserScore++;
                    lblPlayerScorenum.Text = UserScore.ToString();
                    MessageBox.Show("Win");
                    
                }
                else if (lblChoice.Text == "Paper")
                {
                    CompScore++;
                    lblScoreCPU.Text = CompScore.ToString();
                    MessageBox.Show("Lose");
                    
                }

            }
        }

        public void btnRock_Click(object sender, EventArgs e)
        {
           
            lblChoice.Text = "Rock";
        }

        public void btnScissor_Click(object sender, EventArgs e)
        {

            lblChoice.Text = "Scissor";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUserPlayer.Text = name;
        }
    }
}
