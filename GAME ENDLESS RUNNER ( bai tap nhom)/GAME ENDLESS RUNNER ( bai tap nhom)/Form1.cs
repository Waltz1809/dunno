
using InuWayBackHome.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InuWayBackHome
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position;
        Random rand = new Random();
        bool isGameOver = false;




        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            inu.Top += jumpSpeed;

            this.txtScore.BackColor = System.Drawing.Color.Transparent;
           

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (inu.Top > 331 && jumping == false)
            {
                force = 12;
                inu.Top = 330;
                jumpSpeed = 0;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 800) + (x.Width * 15);
                        score++;
                    }

                    if (inu.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        txtScore.Text += "\nNhấn R để chơi lại";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }

            if (score > 15)
            {
                obstacleSpeed = 20;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }


        private void GameReset()
        {
            force = 12;
            jumpSpeed = 10;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            inu.Image = Properties.Resources.shibasmall;
            isGameOver = false;
            inu.Top = 330;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }
            gameTimer.Start();
        }

        private void obstacle2_Click(object sender, EventArgs e)
        {

        }

        private void obstacle1_Click(object sender, EventArgs e)
        {

        }

        private void inu_Click(object sender, EventArgs e)
        {
            inu.BackColor = Color.Transparent;

        }

        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}
