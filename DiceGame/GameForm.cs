using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DiceGame
{
    public partial class GameForm : Form
    {
        //Declare variables for the game
        private int scoreToWin;
        private Boolean twoPlayer = false;
        private Boolean botPlaying = false;
        private List<int> score = new List<int> { 0, 0 };
        private List<string> diceNumList = new List<string>();
        private int activePlayer;
        private int runningScore;
        private Dice dice1;
        private Dice dice2;
        private int playing = 0;
        private int roundsWonPlayer1 = 0;
        private int roundsWonPlayer2 = 0;

        public GameForm()
        {   
            InitializeComponent();
            if (SettingsForm.twoPlayer == true)
            {
                twoPlayer = true;
            }
            else
            {
                twoPlayer = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Text = SettingsForm.winningScore;
            scoreToWin = Convert.ToInt32(SettingsForm.winningScore);
            //Paint the background of the form
            this.Paint += new PaintEventHandler(set_background);
        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(117, 54, 130), Color.FromArgb(191, 46, 52), 10f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        //Reset the varibales of the game
        public void init()
        {
            playing = 1;                        //Let playing the true
            runningScore = 0;                   //Reset the running score to zero
            Random rand = new Random();         //Set new random for the dice
            Random rand1 = new Random();        //Set new random for the dice
            dice1 = new Dice(rand1);
            dice2 = new Dice(rand);
            activePlayer = rand.Next(0, 2);     //Pick the first player ramdomly
            lblCumScore1.Text = "0";            //Reset the label for the cummulative score to zero
            lblCumScore2.Text = "0";             //Reset the label for the cummulative score to zero
            pBoxWinner1.Visible = false;        //Set the visibility of the icon for winning for player 1 to false
            pBoxWinner2.Visible = false;        //Set the visibility of the icon for winning for player 2 to false
            lblPlayer2.Text = twoPlayer == false ? "Bot" : "Player 2";      //If the game is player vs bot, set the label of player 2 into bot, else, vice versa
            lblRoundsWonPlayer2.Text = twoPlayer == false ? "Bot : " : "Player 2 : ";   //If the game is player vs bot, set the label of player 2 in the win rounds controls into bot, else, vice versa
            score = new List<int> { 0, 0 };      //Reset the the cummulative score into zero
            setActivePlayer(activePlayer);
            setButton(playing);
            tBoxScoreBoard.Clear();
            diceNumList.Clear();
            checkIfBotTurn();
            //Set the active player label to the active player
            if (activePlayer == 1 && twoPlayer == false)
            {
                lblactivePlayer.Text = "Bot";
            }
            else
            {
                lblactivePlayer.Text = activePlayer == 0 ? "Player 1" : "Player 2";
            }
            ContinueButton.Text = "Continue";
            ContinueButton.Enabled = false;
        }

        public void setActivePlayer(int number)
        {
            switch (number)
            {
                //set the colour/background for player 1, if the active player is player 1
                case 0:
                    pBoxScreen2.BackColor = Color.FromArgb(48, 25, 52);
                    lblPlayer2.BackColor = Color.FromArgb(48, 25, 52);
                    lblCumScore2.BackColor = Color.FromArgb(48, 25, 52);
                    pBoxScreen1.BackColor = Color.FromArgb(162, 132, 189);
                    lblPlayer1.BackColor = Color.FromArgb(162, 132, 189);
                    lblCumScore1.BackColor = Color.FromArgb(162, 132, 189);
                    pBoxDiceImg1.BackColor = Color.FromArgb(162, 132, 189);
                    pBoxDiceImg1.Visible = true;
                    pBoxDiceImg2.Visible = false;
                    break;

                //set the colour/background for player 2, if the active player is player 2
                case 1:
                    pBoxScreen1.BackColor = Color.FromArgb(48, 25, 52);
                    lblPlayer1.BackColor = Color.FromArgb(48, 25, 52);
                    lblCumScore1.BackColor = Color.FromArgb(48, 25, 52);
                    pBoxScreen2.BackColor = Color.FromArgb(162, 132, 189);
                    lblPlayer2.BackColor = Color.FromArgb(162, 132, 189);
                    lblCumScore2.BackColor = Color.FromArgb(162, 132, 189);
                    pBoxDiceImg2.BackColor = Color.FromArgb(162, 132, 189);
                    pBoxDiceImg1.Visible = false;
                    pBoxDiceImg2.Visible = true;
                    break;
            }
        }

         public void setButton(int playing)
        {
            if (playing == 0)
            {
                //if playing, enable the button for rolling the dice and saving the score 
                btnRollDice.Enabled = false;
                btnSaveScore.Enabled = false;


            }
            else if (playing == 1)
            {
                //if not playing, disable the button for rolling the dice and saving the score 
                btnRollDice.Enabled = true;
                btnSaveScore.Enabled = true;
            }
        }

        class Dice
        {
            private Random rand;
            public Dice(Random rand)
            {
                this.rand = rand;
            }

            //function to roll the dice
            public int roll()
            {
                double random = rand.NextDouble();
                int number = Convert.ToInt32(Math.Truncate(random * 6) + 1);
                return number;
            }
        }

        //Get the image of the dice from Resources
        private Bitmap getDiceImage(int diceNum)
        {
            Bitmap diceImage = new Bitmap(DiceGame.Properties.Resources.dice_1);
            switch (diceNum)
            {
                case 1:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_1);
                    break;
                case 2:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_2);
                    break;
                case 3:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_3);
                    break;
                case 4:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_4);
                    break;
                case 5:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_5);
                    break;
                case 6:
                    diceImage = new Bitmap(DiceGame.Properties.Resources.dice_6);
                    break;
            }
            return diceImage;
        }

        //Randomizing the dice for animation
        private void setDiceAnimation()
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            for (var i = 0; i < 6; i++)
            {
                int random1 = rand1.Next(1, 7);
                int random2 = rand2.Next(1, 7);
                pboxDice1.Image = getDiceImage(random1);
                pboxDice2.Image = getDiceImage(random2);
                //Put the thread to sleep to give the user a sense of the dice are rolling
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
        }

        //Roll both of the dice 
        private void rollTwoDice()
        {
            int dice1Num = dice1.roll();
            int dice2Num = dice2.roll();
            setDiceAnimation();
            //Set the images of the dice into correct numbers
            pboxDice1.Image = getDiceImage(dice1Num);
            pboxDice2.Image = getDiceImage(dice2Num);
            if (dice1Num == 1 && dice2Num == 1)
            {
                runningScore = 0;
                score[activePlayer] = 0;
            }
            else if (dice1Num == 1 || dice2Num == 1)
            {
                runningScore = 0;
            }
            else
            {
                runningScore += dice1Num + dice2Num;
            };

            lblRunningScore.Text = Convert.ToString(runningScore);

            if (activePlayer == 0)
            {
                diceNumList.Add("Player 1 rolls " + Convert.ToString(dice1Num) + " and " + Convert.ToString(dice2Num) + "\n");
                lblCumScore1.Text = Convert.ToString(score[0]);
            }
            else if (activePlayer == 1 && twoPlayer == false)
            {
                diceNumList.Add("Bot rolls " + Convert.ToString(dice1Num) + " and " + Convert.ToString(dice2Num) + "\n");
                lblCumScore2.Text = Convert.ToString(score[1]);
            }
            else
            {
                diceNumList.Add("Player 2 rolls " + Convert.ToString(dice1Num) + " and " + Convert.ToString(dice2Num) + "\n");
                lblCumScore2.Text = Convert.ToString(score[1]);
            }

            if (dice1Num == 1 || dice2Num == 1 || (dice1Num == 1 && dice2Num == 1))
            {
                switchPlayer(activePlayer);
            };
            updateScoreBoard();
        }

        //update the scoreboard to show what numbers had the player rolled
        private void updateScoreBoard()
        {
            tBoxScoreBoard.Clear();
            foreach (var line in diceNumList)
            {
                tBoxScoreBoard.AppendText(line);
                tBoxScoreBoard.AppendText(Environment.NewLine);
            }
        }

        //Switch the turn of the player
        private void switchPlayer(int playerNumber)
        {
            activePlayer = activePlayer == 0 ? 1 : 0;
            setActivePlayer(activePlayer);
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            if (activePlayer == 1 && twoPlayer == false && botPlaying == false)
            {
                checkIfBotTurn();
            }
            else
            {
                lblactivePlayer.Text = activePlayer == 0 ? "Player 1" : "Player 2";
                return;
            }
        }

        //Check if is the turn for the bot
        private void checkIfBotTurn()
        {
            if (activePlayer == 1 && twoPlayer == false)
            {
                lblactivePlayer.Text = "Bot";
                botPlaying = true;
                btnRollDice.Enabled = false;
                btnSaveScore.Enabled = false;
                int count = 0;
                //Bot continues to roll the dice,if the accumulate score is below 30 or the count of the dice is below 4
                while (runningScore < 30 && count <= 3 && botPlaying == true && activePlayer == 1)
                {
                    rollTwoDice();
                    if (activePlayer == 0)
                    {
                        lblactivePlayer.Text = "Player 1";
                        botPlaying = false;
                        btnRollDice.Enabled = true;
                        btnSaveScore.Enabled = true;
                        return;
                    }
                    else
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1500);
                        count++;
                    }


                }
                btnRollDice.Enabled = true;
                btnSaveScore.Enabled = true;
                botPlaying = false;
                saveScore();
            }
        }

        //save the running score of the active player to the current score and switch player
        private void saveScore()
        {
            int curScore = score[activePlayer];
            score[activePlayer] = curScore + runningScore;
            int check = checkIfWin();
            int gameEnds = check == 2 ? 0 : setWinner(check);

            if (activePlayer == 0)
            {
                lblCumScore1.Text = "" + score[0];
            }
            else
            {
                lblCumScore2.Text = "" + score[1];
            }

            lblRunningScore.Text = "0";
            runningScore = 0;

            if (check == 2)
            {
                switchPlayer(activePlayer);
            }
        }

        //check if any player wins 
        private int checkIfWin()
        {
            if(score[0] >= scoreToWin)
            {
                return 0;
            }else if (score[1] >= scoreToWin)
            {
                return 1;
            }
            return 2;
        }

        //set the colour/background of controls to give an appealing view to the end users
        private int setWinner(int playerNum)
        {
            if (playerNum == 0)
            {
                pBoxDiceImg1.Visible = false;
                pBoxWinner1.Visible = true;
                pBoxScreen1.BackColor = Color.Maroon;
                lblCumScore1.BackColor = Color.Maroon;
                lblPlayer1.BackColor = Color.Maroon;
                playing = 0;
                roundsWonPlayer1++;
                lblRoundsWon1.Text = "" + roundsWonPlayer1;
                ContinueButton.Enabled = true;
            }
            else if (playerNum == 1)
            {
                pBoxDiceImg2.Visible = false;
                pBoxWinner2.Visible = true;
                pBoxScreen2.BackColor = Color.Maroon;
                lblCumScore2.BackColor = Color.Maroon;
                lblPlayer2.BackColor = Color.Maroon;
                playing = 0;
                roundsWonPlayer2++;
                lblRoundsWon2.Text = "" + roundsWonPlayer2;
                ContinueButton.Enabled = true;
            }
            setButton(playing);
            return 1;
        }

        //button to roll both of the dice 
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            
            rollTwoDice();
        }


        //button to save the running score
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            MessageBox.Show("Your game will be refreshed.");
            SettingsForm settingsWindow = new SettingsForm();
            this.Hide();
            settingsWindow.Show();
        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            init();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pBoxScreen_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pboxDice_Click(object sender, EventArgs e)
        {

        }

        private void lblCumScore1_Click(object sender, EventArgs e)
        {

        }
        private void pboxDice2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblReminder_Click(object sender, EventArgs e)
        {

        }

        private void pBoxScreen2_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void lblCumScore2_Click(object sender, EventArgs e)
        {

        }

        private void pBoxWinner2_Click(object sender, EventArgs e)
        {

        }

        private void lblRunningScore_Click(object sender, EventArgs e)
        {

        }

        private void pBoxRunScore1_Click(object sender, EventArgs e)
        {

        }

        private void lblRunning_Click(object sender, EventArgs e)
        {

        }

        private void pBoxWinner1_Click(object sender, EventArgs e)
        {

        }

        private void pBoxScreen1_Click(object sender, EventArgs e)
        {

        }

        private void pBoxDiceImg1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rBtn1Player_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn2Player_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void winningScore_Click(object sender, EventArgs e)
        {

        }
    }
}
