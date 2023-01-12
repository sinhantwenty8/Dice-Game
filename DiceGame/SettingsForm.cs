using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class SettingsForm : Form
    {
        //Declare variables
        public static Boolean twoPlayer = false;
        public static string gameStart = "";
        public static string winningScore = "";


        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
         // Set number of players ( 1 or 2 ) in order to start the game
            if (rBtn1Player.Checked)
            {
                twoPlayer = false;
            }
            else if (rBtn2Player.Checked)
            {
                twoPlayer = true;
            }
            else
            {
                labelReminder.Visible = true;
                return;
            }
            // Set winning score for game according to text input in textbox
            winningScore = tBoxWinScore.Text;
            gameStart = "true";
            GameForm gameWindow = new GameForm();

            gameWindow.Size = new Size(2784, 1491);
            //Hide Settings Form 
            this.Hide();
            //Display game form 
            gameWindow.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enable user to input desired winning score
            tBoxWinScore.Enabled = true;
        }

        private void btnSetScoreToWin50_Click(object sender, EventArgs e)
        {
            // Set input in textbox to be 50 
            tBoxWinScore.Text = "50";
            // disable text box winning score editting
            tBoxWinScore.Enabled = false;
        }

        private void tBoxWinScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            // Hide settings form
            this.Hide();
            StartForm startWindow = new StartForm();
            // Show (back to) start form
            startWindow.Size = new Size(1700, 905);
            startWindow.Show();
        }
    }
}
