using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        // Alocating needed variables
        //

        double score = 0;

        int level = 0;

        string buttonNumber;

        bool lost = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.Linen;
            button2.BackColor = Color.Linen;
            button3.BackColor = Color.Linen;
            button4.BackColor = Color.Linen;
            button5.BackColor = Color.Linen;
            button6.BackColor = Color.Linen;
            button7.BackColor = Color.Linen;
            button8.BackColor = Color.Linen;
            button9.BackColor = Color.Linen;
            button10.BackColor = Color.Linen;
            button11.BackColor = Color.Linen;
            button12.BackColor = Color.Linen;
            button13.BackColor = Color.Linen;
            button14.BackColor = Color.Linen;
            button15.BackColor = Color.Linen;
            button16.BackColor = Color.Linen;

            //
            //Changing the color of a random button which should be clicked to get score
            //

            Random randomButton = new Random();

            

            buttonNumber = randomButton.Next(1, 17).ToString();

            switch (buttonNumber)
            {
                case "1":
                    {
                        button1.BackColor = Color.Aquamarine;
                        break;
                    }
                case "2":
                    {
                        button2.BackColor = Color.Aquamarine;
                        break;
                    }
                case "3":
                    {
                        button3.BackColor = Color.Aquamarine;
                        break;
                    }
                case "4":
                    {
                        button4.BackColor = Color.Aquamarine;
                        break;
                    }
                case "5":
                    {
                        button5.BackColor = Color.Aquamarine;
                        break;
                    }
                case "6":
                    {
                        button6.BackColor = Color.Aquamarine;
                        break;
                    }
                case "7":
                    {
                        button7.BackColor = Color.Aquamarine;
                        break;
                    }
                case "8":
                    {
                        button8.BackColor = Color.Aquamarine;
                        break;
                    }
                case "9":
                    {
                        button9.BackColor = Color.Aquamarine;
                        break;
                    }
                case "10":
                    {
                        button10.BackColor = Color.Aquamarine;
                        break;
                    }
                case "11":
                    {
                        button11.BackColor = Color.Aquamarine;
                        break;
                    }
                case "12":
                    {
                        button12.BackColor = Color.Aquamarine;
                        break;
                    }
                case "13":
                    {
                        button13.BackColor = Color.Aquamarine;
                        break;
                    }
                case "14":
                    {
                        button14.BackColor = Color.Aquamarine;
                        break;
                    }
                case "15":
                    {
                        button15.BackColor = Color.Aquamarine;
                        break;
                    }
                case "16":
                    {
                        button16.BackColor = Color.Aquamarine;
                        break;
                    }

                  
            }

            if (lost == true)
            {
                score = 0;
                scoreLabel.Text = score.ToString();

                level = 1;
                levelLabel.Text = level.ToString();

                randomButtonTimer.Interval = 1000;

                lost = false;
            }
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (clickedButton.BackColor == Color.Aquamarine)
                {
                    clickedButton.BackColor = Color.Green;

                    score += 100;

                    scoreLabel.Text = score.ToString();
                }

                else if(clickedButton.BackColor == Color.Linen)
                {
                    clickedButton.BackColor = Color.Red;

                    score -= 100;
                    scoreLabel.Text = score.ToString();                    
                }
                if (score < 0)
                {
                    MessageBox.Show("You Lost!!!");

                    level = 1;
                    levelLabel.Text = level.ToString();

                    lost = true;

                }

            }

        }

        //
        //Functions of score and level
        //

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            if (score > 1000)
            {
                scoreLabel.Text = "0";
                score = 0;
                level = Convert.ToInt32(levelLabel.Text);

                level += 1;

                levelLabel.Text = level.ToString();

                if (level == 2)
                {
                    randomButtonTimer.Interval = 900;
                }

                else if (level == 3)
                {
                    randomButtonTimer.Interval = 800;
                }

                else if (level == 5)
                {
                    randomButtonTimer.Interval = 700;
                }

                else if (level == 6)
                {
                    MessageBox.Show("Great job!!! But I doubt you can go any further.");
                    randomButtonTimer.Interval = 600;
                }

                else if (level == 7)
                {
                    randomButtonTimer.Interval = 500;
                }

                else if (level == 8)
                {
                    MessageBox.Show("You're a Legend Dude!!!");
                    level = 0;
                    levelLabel.Text = level.ToString();
                }

            }
           

        }

        //
        //The function of the "restart" button
        //

        private void restartButton_Click(object sender, EventArgs e)
        {
            score = 0;
            scoreLabel.Text = score.ToString();

            level = 0;
            levelLabel.Text = level.ToString();

            randomButtonTimer.Interval = 1000;
        }

       
    }
}
