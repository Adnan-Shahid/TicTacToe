//Adnan Shahid
//May 8 2014
//TicTacToe
//A tic tac toe application with easy and hard modes vs a computer
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdnanShahid_TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        //Variable Declaration
        Random RandomClass = new Random();
        bool blnWin = false;
        int intPlayerWins = 0;
        int intCompWins = 0;
        int intPlayerTurns = 0;
        int intCompTurns = 0;
        int intTurn;
        int intTurnCounter = 0;
        int intCompChoice;
        int intHardCompChoice;
        int intPlayerSum = 0;
        int intComputerSum = 0;
        bool blnTaken1 = false;
        bool blnTaken2 = false;
        bool blnTaken3 = false;
        bool blnTaken4 = false;
        bool blnTaken5 = false;
        bool blnTaken6 = false;
        bool blnTaken7 = false;
        bool blnTaken8 = false;
        bool blnTaken9 = false;
        int intRadioButtonClick = 0;
        int intCompLevel = 0;


        private void btn1_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken1 == false && intTurn == 0) //Restrictions on player move - Set of comments are true for all btnClicks
            {
                blnTaken1 = true;   //Making it so this button cannot be chosen
                intTurn = 1;    //Changing turn so the computer can be allowed to play
                intPlayerSum = intPlayerSum + 2;    //Increasing the player total sum for value in magic square patter
                this.btn1.Text = "X";   //Changing text on the button to show it is the player's button and is chosen
                intTurnCounter++;   //Increasing the turn counter to get total amount of turns
                intPlayerTurns++;   //Increasing the turn counter to get the total amount of turns
                CheckWinner();      //Checks if player won
                CompMove();         //Playing computer turn
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken2 == false && intTurn == 0)
            {
                blnTaken2 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 9;
                this.btn2.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken3 == false && intTurn == 0)
            {
                blnTaken3 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 4;
                this.btn3.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken4 == false && intTurn == 0)
            {
                blnTaken4 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 7;
                this.btn4.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken5 == false && intTurn == 0)
            {
                blnTaken5 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 5;
                this.btn5.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken6 == false && intTurn == 0)
            {
                blnTaken6 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 3;
                this.btn6.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken7 == false && intTurn == 0)
            {
                blnTaken7 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 6;
                this.btn7.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken8 == false && intTurn == 0)
            {
                blnTaken8 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 1;
                this.btn8.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (intTurnCounter != 9 && blnTaken9 == false && intTurn == 0)  
            {
                blnTaken9 = true;
                intTurn = 1;
                intPlayerSum = intPlayerSum + 8;
                this.btn9.Text = "X";
                intTurnCounter++;
                intPlayerTurns++;
                CheckWinner();
                CompMove();
            }
        }

        public void CompMove()
        {
            //Logic to make computer move
            //Easy mode
            if (intCompLevel == 0)  //Following comments are true for every if statement within the while loop
            {
                while (intTurn == 1 && intTurnCounter != 9) //Restrictions for computer making turn
                {
                    intCompChoice = RandomClass.Next(1, 10);    //Randomly choosing a button - does loop again if button is taken
                    if (blnTaken1 == false && intCompChoice == 1)   //Checking if button is taken and if random number was this button
                    {
                        blnTaken1 = true;   //Making it so button is taken
                        this.btn1.Text = "O";   //Showing that the computer owns this button
                        intComputerSum = intComputerSum + 2;    //Increasing comp sum by value of the button
                        intTurn = 0;    //Changing to player turn
                        intTurnCounter++;   //Increasing total turn counter
                        intCompTurns++; //Increasing computer turns
                        CheckWinner();  //Checks if the computer won during the turn
                        break;
                    }
                    else if (blnTaken2 == false && intCompChoice == 2)
                    {
                        blnTaken2 = true;
                        this.btn2.Text = "O";
                        intComputerSum = intComputerSum + 9;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken3 == false && intCompChoice == 3)
                    {
                        blnTaken3 = true;
                        this.btn3.Text = "O";
                        intComputerSum = intComputerSum + 4;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken4 == false && intCompChoice == 4)
                    {
                        blnTaken4 = true;
                        this.btn4.Text = "O";
                        intComputerSum = intComputerSum + 7;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken5 == false && intCompChoice == 5)
                    {
                        blnTaken5 = true;
                        this.btn5.Text = "O";
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken6 == false && intCompChoice == 6)
                    {
                        blnTaken6 = true;
                        this.btn6.Text = "O";
                        intComputerSum = intComputerSum + 3;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        break;
                    }
                    else if (blnTaken7 == false && intCompChoice == 7)
                    {
                        blnTaken7 = true;
                        this.btn7.Text = "O";
                        intComputerSum = intComputerSum + 6;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken8 == false && intCompChoice == 8)
                    {
                        blnTaken8 = true;
                        this.btn8.Text = "O";
                        intComputerSum = intComputerSum + 1;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken9 == false && intCompChoice == 9)
                    {
                        blnTaken9 = true;
                        this.btn9.Text = "O";
                        intComputerSum = intComputerSum + 8;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                }
            }
            else if (intCompLevel == 1)
            {
                //Hard level computer logic
                while (intTurn == 1 && intTurnCounter != 9) //Restrictions for computer making turn
                {
                    intHardCompChoice = RandomClass.Next(1, 5); 
                    if (blnTaken5 == false) //Takes middle number if not taken
                    {
                        blnTaken5 = true;   //Takes number
                        this.btn5.Text = "O";   //Makes computer own number
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;    //Changing to player turn
                        intTurnCounter++;   //Increasing turn counter
                        intCompTurns++; //Increases comp wins
                        CheckWinner();  //Checks if comp won
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn2.Text == "X" && blnTaken3 == false || this.btn1.Text == "O" && this.btn2.Text == "O" && blnTaken3 == false)  //Checks if either player or computer is about to win
                    {
                        blnTaken3 = true;
                        this.btn3.Text = "O";
                        intComputerSum = intComputerSum + 4;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn3.Text == "X" && blnTaken2 == false || this.btn1.Text == "O" && this.btn3.Text == "O" && blnTaken2 == false)
                    {
                        blnTaken2 = true;
                        this.btn2.Text = "O";
                        intComputerSum = intComputerSum + 9;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn2.Text == "X" && this.btn3.Text == "X" && blnTaken1 == false || this.btn2.Text == "O" && this.btn3.Text == "O" && blnTaken1 == false)
                    {
                        blnTaken1 = true;
                        this.btn1.Text = "O";
                        intComputerSum = intComputerSum + 2;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn4.Text == "X" && this.btn5.Text == "X" && blnTaken6 == false || this.btn4.Text == "O" && this.btn5.Text == "O" && blnTaken6 == false)
                    {
                        blnTaken6 = true;
                        this.btn6.Text = "O";
                        intComputerSum = intComputerSum + 3;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn4.Text == "X" && this.btn6.Text == "X" && blnTaken5 == false || this.btn4.Text == "O" && this.btn6.Text == "O" && blnTaken5 == false)
                    {
                        blnTaken5 = true;
                        this.btn5.Text = "O";
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn5.Text == "X" && this.btn6.Text == "X" && blnTaken4 == false || this.btn5.Text == "O" && this.btn6.Text == "O" && blnTaken4 == false)
                    {
                        blnTaken4 = true;
                        this.btn4.Text = "O";
                        intComputerSum = intComputerSum + 7;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn7.Text == "X" && this.btn8.Text == "X" && blnTaken9 == false || this.btn7.Text == "O" && this.btn8.Text == "O" && blnTaken9 == false)
                    {
                        blnTaken9 = true;
                        this.btn9.Text = "O";
                        intComputerSum = intComputerSum + 8;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn7.Text == "X" && this.btn9.Text == "X" && blnTaken8 == false || this.btn7.Text == "O" && this.btn9.Text == "O" && blnTaken8 == false)
                    {
                        blnTaken8 = true;
                        this.btn8.Text = "O";
                        intComputerSum = intComputerSum + 1;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn8.Text == "X" && this.btn9.Text == "X" && blnTaken7 == false || this.btn8.Text == "O" && this.btn9.Text == "O" && blnTaken7 == false)
                    {
                        blnTaken7 = true;
                        this.btn7.Text = "O";
                        intComputerSum = intComputerSum + 6;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn5.Text == "X" && blnTaken9 == false || this.btn1.Text == "O" && this.btn5.Text == "O" && blnTaken9 == false)
                    {
                        blnTaken9 = true;
                        this.btn9.Text = "O";
                        intComputerSum = intComputerSum + 8;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn9.Text == "X" && blnTaken5 == false || this.btn1.Text == "O" && this.btn9.Text == "O" && blnTaken5 == false)
                    {
                        blnTaken5 = true;
                        this.btn5.Text = "O";
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn5.Text == "X" && this.btn9.Text == "X" && blnTaken1 == false || this.btn5.Text == "O" && this.btn9.Text == "O" && blnTaken1 == false)
                    {
                        blnTaken1 = true;
                        this.btn1.Text = "O";
                        intComputerSum = intComputerSum + 2;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn3.Text == "X" && this.btn5.Text == "X" && blnTaken7 == false || this.btn3.Text == "O" && this.btn5.Text == "O" && blnTaken7 == false)
                    {
                        blnTaken7 = true;
                        this.btn7.Text = "O";
                        intComputerSum = intComputerSum + 6;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn3.Text == "X" && this.btn7.Text == "X" && blnTaken5 == false || this.btn3.Text == "O" && this.btn7.Text == "O" && blnTaken5 == false)
                    {
                        blnTaken5 = true;
                        this.btn5.Text = "O";
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn5.Text == "X" && this.btn7.Text == "X" && blnTaken3 == false || this.btn5.Text == "O" && this.btn7.Text == "O" && blnTaken3 == false)
                    {
                        blnTaken3 = true;
                        this.btn3.Text = "O";
                        intComputerSum = intComputerSum + 4;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn4.Text == "X" && blnTaken7 == false || this.btn1.Text == "O" && this.btn4.Text == "O" && blnTaken7 == false)
                    {
                        blnTaken7 = true;
                        this.btn7.Text = "O";
                        intComputerSum = intComputerSum + 6;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn1.Text == "X" && this.btn7.Text == "X" && blnTaken4 == false || this.btn1.Text == "O" && this.btn7.Text == "O" && blnTaken4 == false)
                    {
                        blnTaken4 = true;
                        this.btn4.Text = "O";
                        intComputerSum = intComputerSum + 7;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn4.Text == "X" && this.btn7.Text == "X" && blnTaken1 == false || this.btn4.Text == "O" && this.btn7.Text == "O" && blnTaken1 == false)
                    {
                        blnTaken1 = true;
                        this.btn1.Text = "O";
                        intComputerSum = intComputerSum + 2;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn2.Text == "X" && this.btn5.Text == "X" && blnTaken8 == false || this.btn2.Text == "O" && this.btn5.Text == "O" && blnTaken8 == false)
                    {
                        blnTaken8 = true;
                        this.btn8.Text = "O";
                        intComputerSum = intComputerSum + 1;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn2.Text == "X" && this.btn8.Text == "X" && blnTaken5 == false || this.btn2.Text == "O" && this.btn8.Text == "O" && blnTaken5 == false)
                    {
                        blnTaken5 = true;
                        this.btn5.Text = "O";
                        intComputerSum = intComputerSum + 5;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn5.Text == "X" && this.btn8.Text == "X" && blnTaken2 == false || this.btn5.Text == "O" && this.btn8.Text == "O" && blnTaken2 == false)
                    {
                        blnTaken2 = true;
                        this.btn2.Text = "O";
                        intComputerSum = intComputerSum + 9;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn3.Text == "X" && this.btn6.Text == "X" && blnTaken9 == false || this.btn3.Text == "O" && this.btn6.Text == "O" && blnTaken9 == false)
                    {
                        blnTaken9 = true;
                        this.btn9.Text = "O";
                        intComputerSum = intComputerSum + 8;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn3.Text == "X" && this.btn9.Text == "X" && blnTaken6 == false || this.btn3.Text == "O" && this.btn9.Text == "O" && blnTaken6 == false)
                    {
                        blnTaken6 = true;
                        this.btn6.Text = "O";
                        intComputerSum = intComputerSum + 3;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (this.btn6.Text == "X" && this.btn9.Text == "X" && blnTaken3 == false || this.btn6.Text == "O" && this.btn9.Text == "O" && blnTaken3 == false)
                    {
                        blnTaken3 = true;
                        this.btn3.Text = "O";
                        intComputerSum = intComputerSum + 4;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken5 == true && intHardCompChoice == 1 && blnTaken2 == false) //Takes even button if no one will win
                    {
                        blnTaken2 = true;
                        this.btn2.Text = "O";
                        intComputerSum = intComputerSum + 9;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken5 == true && intHardCompChoice == 2 && blnTaken4 == false)
                    {
                        blnTaken4 = true;
                        this.btn4.Text = "O";
                        intComputerSum = intComputerSum + 7;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken5 == true && intHardCompChoice == 3 && blnTaken6 == false)
                    {
                        blnTaken6 = true;
                        this.btn6.Text = "O";
                        intComputerSum = intComputerSum + 3;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }
                    else if (blnTaken5 == true && intHardCompChoice == 4 && blnTaken8 == false)
                    {
                        blnTaken8 = true;
                        this.btn8.Text = "O";
                        intComputerSum = intComputerSum + 1;
                        intTurn = 0;
                        intTurnCounter++;
                        intCompTurns++;
                        CheckWinner();
                        break;
                    }

                }
            }

        }
        public void CheckWinner()   //Checks the winner
        {
            if (this.btn1.Text == "X" && this.btn4.Text == "X" && this.btn7.Text == "X" && intPlayerSum >= 15)  //Conditions for winning
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9; //Makes sure no one can play
                intPlayerWins++;    //Increases win counter
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);  //Placing wins into the label
                blnWin = true;  //Drawcheck
            }
            else if (this.btn1.Text == "X" && this.btn5.Text == "X" && this.btn9.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn1.Text == "X" && this.btn2.Text == "X" && this.btn3.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn3.Text == "X" && this.btn5.Text == "X" && this.btn7.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn2.Text == "X" && this.btn5.Text == "X" && this.btn8.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn3.Text == "X" && this.btn6.Text == "X" && this.btn9.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn4.Text == "X" && this.btn5.Text == "X" && this.btn6.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }
            else if (this.btn7.Text == "X" && this.btn8.Text == "X" && this.btn9.Text == "X" && intPlayerSum >= 15)
            {
                MessageBox.Show("You won! Click the reset button to reset the field and play another round");
                intTurnCounter = 9;
                intPlayerWins++;
                lblPlayerScore.Text = Convert.ToString(intPlayerWins);
                blnWin = true;
            }

            //Computer checker -- checks all possible ways if the comp can win and returns message if true
            if (this.btn1.Text == "O" && this.btn4.Text == "O" && this.btn7.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn1.Text == "O" && this.btn5.Text == "O" && this.btn9.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn1.Text == "O" && this.btn2.Text == "O" && this.btn3.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn3.Text == "O" && this.btn5.Text == "O" && this.btn7.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn2.Text == "O" && this.btn5.Text == "O" && this.btn8.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn3.Text == "O" && this.btn6.Text == "O" && this.btn9.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn4.Text == "O" && this.btn5.Text == "O" && this.btn6.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            else if (this.btn7.Text == "O" && this.btn8.Text == "O" && this.btn9.Text == "O" && intComputerSum >= 15)
            {
                intTurnCounter = 9;
                MessageBox.Show("The computer won! You lose, try again!\nClick the reset button to reset the field and play another round");
                intCompWins++;
                lblComputerScore.Text = Convert.ToString(intCompWins);
                blnWin = true;
            }
            //draw check
            else if (blnWin == false && blnTaken1 == true && blnTaken2 == true && blnTaken3 == true && blnTaken4 == true && blnTaken5 == true && blnTaken6 == true && blnTaken7 == true && blnTaken8 == true && blnTaken9 == true)
            {
                blnWin = true;
                intTurnCounter = 9;
                MessageBox.Show("It was a draw! Click the reset button to reset the field and\n play another round");
            }
        }
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            intTurn = 9;
        }

        private void lblTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();    //To prevent a bug from occuring
            Reset();


        }
        public void Reset()
        {
            intTurnCounter = 9;
            intTurn = 69;   //Placeholder number so no one can play after the reset until the player chooses who goes first
            intPlayerSum = 0;
            intComputerSum = 0;
            blnWin = false;
            blnTaken1 = false;
            blnTaken2 = false;
            blnTaken3 = false;
            blnTaken4 = false;
            blnTaken5 = false;
            blnTaken6 = false;
            blnTaken7 = false;
            blnTaken8 = false;
            blnTaken9 = false;
            intPlayerTurns = 0;
            intCompTurns = 0;
            this.btn1.Text = "";
            this.btn2.Text = "";
            this.btn3.Text = "";
            this.btn4.Text = "";
            this.btn5.Text = "";
            this.btn6.Text = "";
            this.btn7.Text = "";
            this.btn8.Text = "";
            this.btn9.Text = "";
            rbPlayerStart.Checked = false;
            rbComputerStart.Checked = false;
            intRadioButtonClick = 0;
        }

        private void lblPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void lblComputerScore_Click(object sender, EventArgs e)
        {

        }

        private void MnuRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();  //Restart app
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit app
        }

        private void rbPlayerStart_CheckedChanged(object sender, EventArgs e)
        {
            if (intRadioButtonClick != 1)   //Made so that the user cannot click the button more than once
            {
                intRadioButtonClick = 1;    //Changing it so that it is taken
                intTurn = 0;    //Makes player turn
                intTurnCounter = 0;
            }
        }

        private void rbComputerStart_CheckedChanged(object sender, EventArgs e)
        {
            if (intRadioButtonClick != 1)   //Mde so that the user cannot click the button more than once
            {
                intRadioButtonClick = 1;    //Changing it so it is taken
                intTurn = 1;    //Make comp turn
                intTurnCounter = 0;
                CompMove();
            }
        }

        private void mnuEasy_Click(object sender, EventArgs e)
        {
            intCompLevel = 0;
            Reset();
            Reset();
        }

        private void mnuHard_Click(object sender, EventArgs e)
        {
            intCompLevel = 1;   //Hard mode
            Reset();
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        
    }
}
