using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw002
{
    public partial class TheGame : Form
    {
        bool LeftKey, RightKey , StartKey;
        int score = 0;
        int life = 5;
        int speed = 6;
        static int bestScore = 0;

        Random Xnum = new Random();
        Random Ynum = new Random();
        public TheGame()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Restart();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            scoreTxt.Text = "Eated : " + score;
            LifeTxt.Text = "Life left: " + life;
            BestScorelbl.Text = "Best Score: " + bestScore;


            if (LeftKey == true && player.Left > 0)
            {
                player.Left -= 75;
            }
            if (RightKey == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 75;
            }

            if (StartKey)
            {
                
            foreach (Control item in this.Controls)
            {

                if (item is PictureBox && (string)item.Tag == "fish")
                {
                    item.Top += speed;

                    if (item.Top + item.Height > this.ClientSize.Height)
                    {
                        item.Top = Ynum.Next(30, 80);
                        item.Left = Xnum.Next(5, this.ClientSize.Width - item.Width);
                        life -= 1;
                    }

                    if (player.Bounds.IntersectsWith(item.Bounds))
                    {
                        item.Top = Ynum.Next(30, 80);
                        item.Left = Xnum.Next(5, this.ClientSize.Width - item.Width);
                        score += 1;
                        speed += 1;
                    }
                }

            }
            }

            if (life == 0)
            {
                if (bestScore < score)
                {
                    bestScore = score;
                }
                GameTimer.Stop();
                if (MessageBox.Show("Game Over, Play again?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartKey = true;
                    Restart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftKey = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                RightKey = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                StartKey = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftKey = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                RightKey = false;
            }
        }

        private void TheGame_Load(object sender, EventArgs e)
        {

        }




        private void Restart()
        {
            score = 0;
            life = 5;
            speed = 8;
            LeftKey = false;
            RightKey = false;
            GameTimer.Start();

            foreach (Control item in Controls)
            {
                if (item is PictureBox && (string)item.Tag == "fish")
                {
                    item.Top = Xnum.Next(30, 80);
                    item.Left = Ynum.Next(5, this.ClientSize.Width - item.Width);
                }
            }
        }
    }
}
