using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project2Attempt2_ALB
{
    public partial class Form1 : Form
    {
        int die1 = 1;
        int die2 = 2;
        int balance = 100;
        int dieSum;
        int bet = 15;
        int point = 0;

        public Form1()
        {
            try
            {
                Image myimage = new Bitmap(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\greenfelt.jpg");
                this.BackgroundImage = myimage;
            }
            catch (Exception)
            {

            }
            InitializeComponent();
        }

        private void die1Update(int n)
        {
            try
            {
                switch (n)
                {
                    case 1:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice1.png");
                        pbDie1.Update();
                        break;
                    case 2:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice2.png");
                        pbDie1.Update();
                        break;
                    case 3:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice3.png");
                        pbDie1.Update();
                        break;
                    case 4:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice4.png");
                        pbDie1.Update();
                        break;
                    case 5:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice5.png");
                        pbDie1.Update();
                        break;
                    case 6:
                        pbDie1.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice6.png");
                        pbDie1.Update();
                        break;
                }
            }
            catch (Exception)
            {

            }
            
        }//endDie1Update

        private void die2Update(int n)
        {
            try
            {
                switch (n)
                {
                    case 1:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice1.png");
                        pbDie2.Update();
                        break;
                    case 2:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice2.png");
                        pbDie2.Update();
                        break;
                    case 3:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice3.png");
                        pbDie2.Update();
                        break;
                    case 4:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice4.png");
                        pbDie2.Update();
                        break;
                    case 5:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice5.png");
                        pbDie2.Update();
                        break;
                    case 6:
                        pbDie2.Image = Image.FromFile(@"C:\Users\TCW\source\repos\CS311_Project2Attempt2_ALB\CS311_Project2Attempt2_ALB\Resources\dice6.png");
                        pbDie2.Update();
                        break;
                }
            }
            catch (Exception)
            {

            }
        }//end die2Update

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Craps";
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblBalanceTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnRoil_Click(object sender, EventArgs e)
        {
            try
            {
                String temp = txtbBet.Text;
                bet = Convert.ToInt32(temp);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Your Bet!");
            }
            
            if (bet > balance)
            {
                MessageBox.Show("You're Broke.");
            }
            else
            {
                lblYouWin.Visible = false;
                lblYouLose.Visible = false;
                lblRollAgain.Visible = false;
                Random r = new Random();
                die1 = r.Next(1, 6);
                die2 = r.Next(1, 6);
                die1Update(die1);
                die2Update(die2);
                dieSum = die1 + die2;
                calculateScore(dieSum);
            }
        }

        private void calculateScore(int n)
        {
            switch (n)
            {
                case 2:
                    if (point == 0)
                    {
                        balance = balance - bet;
                        updateBalance();
                        lblYouLose.Visible = true;
                        break;
                    }//end if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 3:
                    if (point == 0)
                    {
                        balance = balance - bet;
                        lblYouLose.Visible = true;
                    }//end if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    break;
                case 4:
                    if (point == 0)
                    {
                        point = 4;
                        lblPoint.Text = "4";
                        lblRollAgain.Visible = true;
                        break;
                    }//end if
                    if (point == 4)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }

                case 5:
                    if (point == 0)
                    {
                        lblRollAgain.Visible=true;
                        point = 5;
                        lblPoint.Text = "5";
                        break;
                    }//end if
                    if (point == 5)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 6:
                    if (point == 0)
                    {
                        lblRollAgain.Visible = true;
                        point = 6;
                        lblPoint.Text = "6";
                        break;
                    }//end if
                    if (point == 6)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 7:
                    if (point == 0)
                    {
                        balance = balance + bet;
                        updateBalance();
                        lblYouWin.Visible = true;
                        break;
                    }//end if
                    else if (point != 0)
                    {
                        balance = balance - bet;
                        updateBalance();
                        point = 0;
                        lblYouLose.Visible = true;
                        break;
                    }// end else if
                    else
                    {
                        break;
                    }
                    
                case 8:
                    if (point == 0)
                    {
                        lblRollAgain.Visible = true;
                        point = 8;
                        lblPoint.Text = "8";
                        break;
                    }//end if
                    if (point == 8)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 9:
                    if (point == 0)
                    {
                        lblRollAgain.Visible=true;
                        lblPoint.Text = "9";
                        point = 9;
                        break;
                    }//end if
                    if (point == 9)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 10:
                    if (point == 0)
                    {
                        lblRollAgain.Visible=true;
                        lblPoint.Text = "10";
                        point = 10;
                        break;
                    }//end if
                    if (point == 10)
                    {
                        lblYouWin.Visible = true;
                        balance = pointWinReset(balance, bet);
                        updateBalance();
                        break;
                    }//win if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 11:
                    if (point == 0)
                    {
                        pointWinReset(balance, bet);
                        updateBalance();
                        lblYouLose.Visible = true;
                        break;
                    }//end if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    
                case 12:
                    if (point == 0)
                    {
                        balance=balance-bet;
                        updateBalance();
                        lblYouLose.Visible = true;
                        break;
                    }//end if
                    else
                    {
                        lblRollAgain.Visible = true;
                        break;
                    }
                    

            }//end switch 
        }//end calculate Score

        private void updateBalance()
        {
            try
            {
                lblBalanceTotal.Text = Convert.ToString(balance);
            }
            catch (Exception)
            {

            }
            
        }//end updateBalance

        private int pointWinReset(int b, int be)
        {
            b = b + be;
            point = 0;
            return b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentPoint_Click(object sender, EventArgs e)
        {

        }
    }
}
