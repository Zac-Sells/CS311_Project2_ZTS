namespace Craps
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void lblBank_Click(object sender, EventArgs e)
        {

        }
        
        private void btnRoll_Click(object sender, EventArgs e)
        {
           
            calculate_Score();
        }
        int total;
        

        //creates a method used to roll dice
        private void roll_Dice()
        {
            Random rnd = new Random();
            int D1 = rnd.Next(1, 7);
            int D2 = rnd.Next(1, 7);
            lblDice1.Text = D1.ToString();
            lblDice2.Text = D2.ToString();
            total = D1 + D2;
        }
        //creates a method to play craps
        private void calculate_Score()
        {
            
            int point;
            int balance = int.Parse(lblBank.Text);
            int bet = int.Parse(txtBet.Text);
            int newBalance;
            String Result;
            if (balance > bet)
            {
                
                lblPoints.Text = "";
                roll_Dice();
                switch (total)
                {
                    case 2:
                        Result = "You lose";
                        lblOutCome.Text = Result;
                        newBalance = balance - bet;
                        lblBank.Text = newBalance.ToString();
                        break;

                    case 3:
                        Result = "You lose";
                        lblOutCome.Text = Result;
                        newBalance = balance - bet;
                        lblBank.Text = newBalance.ToString();
                        break;
                    case 4:
                        Result = "Point";
                        point = 4;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 4)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }

                        }

                        break;
                    case 5:
                        Result = "Point";
                        point = 5;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 5)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }

                        }

                        break;
                    case 6:
                        Result = "Point";
                        point = 6;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 6)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;


                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;


                            }

                        }

                        break;
                    case 7:
                        Result = "You Win!";
                        lblOutCome.Text = Result;
                        newBalance = balance + bet;
                        lblBank.Text = newBalance.ToString();
                        break;
                    case 8:
                        Result = "Point";
                        point = 8;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 8)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }

                        }

                        break;
                    case 9:
                        Result = "Point";
                        point = 9;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 9)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }

                        }

                        break;
                    case 10:
                        Result = "Point";
                        point = 10;
                        lblOutCome.Text = Result + " " + point.ToString();
                        lblPoints.Text = "Points =" + " " + point.ToString();
                        while (Result == "Point")
                        {
                            roll_Dice();
                            if (total == 10)
                            {
                                Result = "You Win!";
                                lblOutCome.Text = Result;
                                newBalance = balance + bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }
                            if (total == 7)
                            {
                                Result = "You lose";
                                lblOutCome.Text = Result;
                                newBalance = balance - bet;
                                lblBank.Text = newBalance.ToString();
                                break;

                            }

                        }

                        break;
                    case 11:
                        Result = "You Win!";
                        lblOutCome.Text = Result;
                        newBalance = balance + bet;
                        lblBank.Text = newBalance.ToString();
                        break;
                    case 12:
                        Result = "You lose";
                        lblOutCome.Text = Result;
                        newBalance = balance - bet;
                        lblBank.Text = newBalance.ToString();
                        break;

                }//end switch    
            }
            
            else
            {
                {
                    MessageBox.Show("Not enough money to make bet.");
                }
            }//end else

        }//end calc score

    }//end class
}//end namespace

    



