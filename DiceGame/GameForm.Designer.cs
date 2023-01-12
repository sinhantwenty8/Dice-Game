
namespace DiceGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblCumScore1 = new System.Windows.Forms.Label();
            this.lblCumScore2 = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.lblRunningScore = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblactivePlayer = new System.Windows.Forms.Label();
            this.tBoxScoreBoard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoundsWonPlayer1 = new System.Windows.Forms.Label();
            this.lblRoundsWonPlayer2 = new System.Windows.Forms.Label();
            this.lblRoundsWon1 = new System.Windows.Forms.Label();
            this.lblRoundsWon2 = new System.Windows.Forms.Label();
            this.lblwinningScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxRoundsWon = new System.Windows.Forms.PictureBox();
            this.pBoxDice = new System.Windows.Forms.PictureBox();
            this.pBoxTurn = new System.Windows.Forms.PictureBox();
            this.pBoxWinner1 = new System.Windows.Forms.PictureBox();
            this.pBoxWinner2 = new System.Windows.Forms.PictureBox();
            this.pBoxDiceImg1 = new System.Windows.Forms.PictureBox();
            this.pBoxDiceImg2 = new System.Windows.Forms.PictureBox();
            this.pboxDice2 = new System.Windows.Forms.PictureBox();
            this.pBoxRunScore1 = new System.Windows.Forms.PictureBox();
            this.pboxDice1 = new System.Windows.Forms.PictureBox();
            this.pBoxScreen2 = new System.Windows.Forms.PictureBox();
            this.pBoxScreen1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRoundsWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWinner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWinner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDiceImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDiceImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRunScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreen1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(568, 533);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(740, 60);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(1380, 533);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(788, 60);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer2.Click += new System.EventHandler(this.lblPlayer2_Click);
            // 
            // lblCumScore1
            // 
            this.lblCumScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.lblCumScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblCumScore1.ForeColor = System.Drawing.Color.White;
            this.lblCumScore1.Location = new System.Drawing.Point(720, 635);
            this.lblCumScore1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCumScore1.Name = "lblCumScore1";
            this.lblCumScore1.Size = new System.Drawing.Size(432, 152);
            this.lblCumScore1.TabIndex = 5;
            this.lblCumScore1.Text = "0";
            this.lblCumScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCumScore1.Click += new System.EventHandler(this.lblCumScore1_Click);
            // 
            // lblCumScore2
            // 
            this.lblCumScore2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.lblCumScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblCumScore2.ForeColor = System.Drawing.Color.White;
            this.lblCumScore2.Location = new System.Drawing.Point(1580, 635);
            this.lblCumScore2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCumScore2.Name = "lblCumScore2";
            this.lblCumScore2.Size = new System.Drawing.Size(366, 152);
            this.lblCumScore2.TabIndex = 6;
            this.lblCumScore2.Text = "0";
            this.lblCumScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCumScore2.Click += new System.EventHandler(this.lblCumScore2_Click);
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblRunning.ForeColor = System.Drawing.Color.White;
            this.lblRunning.Location = new System.Drawing.Point(1294, 1096);
            this.lblRunning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(145, 39);
            this.lblRunning.TabIndex = 8;
            this.lblRunning.Text = "Running";
            this.lblRunning.Click += new System.EventHandler(this.lblRunning_Click);
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.lblRunningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRunningScore.ForeColor = System.Drawing.Color.White;
            this.lblRunningScore.Location = new System.Drawing.Point(1254, 1137);
            this.lblRunningScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(240, 88);
            this.lblRunningScore.TabIndex = 11;
            this.lblRunningScore.Text = "0";
            this.lblRunningScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRunningScore.Click += new System.EventHandler(this.lblRunningScore_Click);
            // 
            // btnRollDice
            // 
            this.btnRollDice.Enabled = false;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRollDice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.btnRollDice.Location = new System.Drawing.Point(1284, 852);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(6);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(156, 56);
            this.btnRollDice.TabIndex = 13;
            this.btnRollDice.Text = "🎲 Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Enabled = false;
            this.btnSaveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.btnSaveScore.Location = new System.Drawing.Point(1192, 948);
            this.btnSaveScore.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(350, 65);
            this.btnSaveScore.TabIndex = 14;
            this.btnSaveScore.Text = "📩 Save Your Score";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(1215, 157);
            this.lblGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(305, 107);
            this.lblGame.TabIndex = 15;
            this.lblGame.Text = "Groan";
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTurn.Location = new System.Drawing.Point(40, 396);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(442, 54);
            this.lblTurn.TabIndex = 31;
            this.lblTurn.Text = "Turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblactivePlayer
            // 
            this.lblactivePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblactivePlayer.Location = new System.Drawing.Point(52, 506);
            this.lblactivePlayer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblactivePlayer.Name = "lblactivePlayer";
            this.lblactivePlayer.Size = new System.Drawing.Size(430, 87);
            this.lblactivePlayer.TabIndex = 32;
            this.lblactivePlayer.Text = "-";
            this.lblactivePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxScoreBoard
            // 
            this.tBoxScoreBoard.BackColor = System.Drawing.Color.White;
            this.tBoxScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxScoreBoard.Cursor = System.Windows.Forms.Cursors.No;
            this.tBoxScoreBoard.Enabled = false;
            this.tBoxScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxScoreBoard.ForeColor = System.Drawing.Color.Indigo;
            this.tBoxScoreBoard.Location = new System.Drawing.Point(60, 798);
            this.tBoxScoreBoard.Margin = new System.Windows.Forms.Padding(6);
            this.tBoxScoreBoard.Multiline = true;
            this.tBoxScoreBoard.Name = "tBoxScoreBoard";
            this.tBoxScoreBoard.ReadOnly = true;
            this.tBoxScoreBoard.Size = new System.Drawing.Size(402, 504);
            this.tBoxScoreBoard.TabIndex = 33;
            this.tBoxScoreBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(2265, 667);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rounds won";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRoundsWonPlayer1
            // 
            this.lblRoundsWonPlayer1.AutoSize = true;
            this.lblRoundsWonPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoundsWonPlayer1.Location = new System.Drawing.Point(2305, 734);
            this.lblRoundsWonPlayer1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoundsWonPlayer1.Name = "lblRoundsWonPlayer1";
            this.lblRoundsWonPlayer1.Size = new System.Drawing.Size(158, 37);
            this.lblRoundsWonPlayer1.TabIndex = 37;
            this.lblRoundsWonPlayer1.Text = "Player 1 : ";
            // 
            // lblRoundsWonPlayer2
            // 
            this.lblRoundsWonPlayer2.AutoSize = true;
            this.lblRoundsWonPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoundsWonPlayer2.Location = new System.Drawing.Point(2305, 799);
            this.lblRoundsWonPlayer2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoundsWonPlayer2.Name = "lblRoundsWonPlayer2";
            this.lblRoundsWonPlayer2.Size = new System.Drawing.Size(160, 37);
            this.lblRoundsWonPlayer2.TabIndex = 39;
            this.lblRoundsWonPlayer2.Text = "Player 2 : ";
            // 
            // lblRoundsWon1
            // 
            this.lblRoundsWon1.AutoSize = true;
            this.lblRoundsWon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblRoundsWon1.Location = new System.Drawing.Point(2593, 734);
            this.lblRoundsWon1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoundsWon1.Name = "lblRoundsWon1";
            this.lblRoundsWon1.Size = new System.Drawing.Size(36, 39);
            this.lblRoundsWon1.TabIndex = 40;
            this.lblRoundsWon1.Text = "0";
            // 
            // lblRoundsWon2
            // 
            this.lblRoundsWon2.AutoSize = true;
            this.lblRoundsWon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblRoundsWon2.Location = new System.Drawing.Point(2593, 799);
            this.lblRoundsWon2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoundsWon2.Name = "lblRoundsWon2";
            this.lblRoundsWon2.Size = new System.Drawing.Size(36, 39);
            this.lblRoundsWon2.TabIndex = 41;
            this.lblRoundsWon2.Text = "0";
            // 
            // lblwinningScore
            // 
            this.lblwinningScore.AutoSize = true;
            this.lblwinningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinningScore.Location = new System.Drawing.Point(2317, 391);
            this.lblwinningScore.Name = "lblwinningScore";
            this.lblwinningScore.Size = new System.Drawing.Size(329, 61);
            this.lblwinningScore.TabIndex = 43;
            this.lblwinningScore.Text = "Score to Win";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblScore.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScore.Location = new System.Drawing.Point(2308, 464);
            this.lblScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(366, 111);
            this.lblScore.TabIndex = 44;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Click += new System.EventHandler(this.winningScore_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(2237, 1052);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(514, 83);
            this.ResetButton.TabIndex = 45;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.LoadGame);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(2237, 931);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(514, 82);
            this.ContinueButton.TabIndex = 46;
            this.ContinueButton.Text = "Start";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2233, 365);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 229);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxRoundsWon
            // 
            this.pBoxRoundsWon.Location = new System.Drawing.Point(2237, 635);
            this.pBoxRoundsWon.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxRoundsWon.Name = "pBoxRoundsWon";
            this.pBoxRoundsWon.Size = new System.Drawing.Size(514, 229);
            this.pBoxRoundsWon.TabIndex = 35;
            this.pBoxRoundsWon.TabStop = false;
            // 
            // pBoxDice
            // 
            this.pBoxDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxDice.Location = new System.Drawing.Point(26, 777);
            this.pBoxDice.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxDice.Name = "pBoxDice";
            this.pBoxDice.Size = new System.Drawing.Size(474, 546);
            this.pBoxDice.TabIndex = 30;
            this.pBoxDice.TabStop = false;
            // 
            // pBoxTurn
            // 
            this.pBoxTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxTurn.Location = new System.Drawing.Point(24, 363);
            this.pBoxTurn.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxTurn.Name = "pBoxTurn";
            this.pBoxTurn.Size = new System.Drawing.Size(476, 377);
            this.pBoxTurn.TabIndex = 29;
            this.pBoxTurn.TabStop = false;
            // 
            // pBoxWinner1
            // 
            this.pBoxWinner1.BackColor = System.Drawing.Color.Maroon;
            this.pBoxWinner1.Image = global::DiceGame.Properties.Resources.icons8_win_66;
            this.pBoxWinner1.Location = new System.Drawing.Point(860, 881);
            this.pBoxWinner1.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxWinner1.Name = "pBoxWinner1";
            this.pBoxWinner1.Size = new System.Drawing.Size(146, 133);
            this.pBoxWinner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxWinner1.TabIndex = 28;
            this.pBoxWinner1.TabStop = false;
            this.pBoxWinner1.Visible = false;
            this.pBoxWinner1.Click += new System.EventHandler(this.pBoxWinner1_Click);
            // 
            // pBoxWinner2
            // 
            this.pBoxWinner2.BackColor = System.Drawing.Color.Maroon;
            this.pBoxWinner2.Image = global::DiceGame.Properties.Resources.icons8_win_66;
            this.pBoxWinner2.Location = new System.Drawing.Point(1692, 881);
            this.pBoxWinner2.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxWinner2.Name = "pBoxWinner2";
            this.pBoxWinner2.Size = new System.Drawing.Size(146, 133);
            this.pBoxWinner2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxWinner2.TabIndex = 27;
            this.pBoxWinner2.TabStop = false;
            this.pBoxWinner2.Visible = false;
            this.pBoxWinner2.Click += new System.EventHandler(this.pBoxWinner2_Click);
            // 
            // pBoxDiceImg1
            // 
            this.pBoxDiceImg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.pBoxDiceImg1.Image = global::DiceGame.Properties.Resources.icons8_dice_48;
            this.pBoxDiceImg1.Location = new System.Drawing.Point(862, 881);
            this.pBoxDiceImg1.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxDiceImg1.Name = "pBoxDiceImg1";
            this.pBoxDiceImg1.Size = new System.Drawing.Size(146, 133);
            this.pBoxDiceImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDiceImg1.TabIndex = 26;
            this.pBoxDiceImg1.TabStop = false;
            this.pBoxDiceImg1.Visible = false;
            this.pBoxDiceImg1.Click += new System.EventHandler(this.pBoxDiceImg1_Click);
            // 
            // pBoxDiceImg2
            // 
            this.pBoxDiceImg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.pBoxDiceImg2.Image = global::DiceGame.Properties.Resources.icons8_dice_48;
            this.pBoxDiceImg2.Location = new System.Drawing.Point(1692, 881);
            this.pBoxDiceImg2.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxDiceImg2.Name = "pBoxDiceImg2";
            this.pBoxDiceImg2.Size = new System.Drawing.Size(146, 133);
            this.pBoxDiceImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDiceImg2.TabIndex = 25;
            this.pBoxDiceImg2.TabStop = false;
            this.pBoxDiceImg2.Visible = false;
            // 
            // pboxDice2
            // 
            this.pboxDice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxDice2.Image = global::DiceGame.Properties.Resources.dice_1;
            this.pboxDice2.Location = new System.Drawing.Point(1380, 615);
            this.pboxDice2.Margin = new System.Windows.Forms.Padding(6);
            this.pboxDice2.Name = "pboxDice2";
            this.pboxDice2.Size = new System.Drawing.Size(188, 167);
            this.pboxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDice2.TabIndex = 18;
            this.pboxDice2.TabStop = false;
            this.pboxDice2.Click += new System.EventHandler(this.pboxDice2_Click);
            // 
            // pBoxRunScore1
            // 
            this.pBoxRunScore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.pBoxRunScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxRunScore1.Location = new System.Drawing.Point(1218, 1073);
            this.pBoxRunScore1.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxRunScore1.Name = "pBoxRunScore1";
            this.pBoxRunScore1.Size = new System.Drawing.Size(302, 183);
            this.pBoxRunScore1.TabIndex = 7;
            this.pBoxRunScore1.TabStop = false;
            this.pBoxRunScore1.Click += new System.EventHandler(this.pBoxRunScore1_Click);
            // 
            // pboxDice1
            // 
            this.pboxDice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxDice1.Image = ((System.Drawing.Image)(resources.GetObject("pboxDice1.Image")));
            this.pboxDice1.Location = new System.Drawing.Point(1164, 615);
            this.pboxDice1.Margin = new System.Windows.Forms.Padding(6);
            this.pboxDice1.Name = "pboxDice1";
            this.pboxDice1.Size = new System.Drawing.Size(188, 167);
            this.pboxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDice1.TabIndex = 4;
            this.pboxDice1.TabStop = false;
            this.pboxDice1.Click += new System.EventHandler(this.pboxDice_Click);
            // 
            // pBoxScreen2
            // 
            this.pBoxScreen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.pBoxScreen2.Location = new System.Drawing.Point(1368, 363);
            this.pBoxScreen2.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxScreen2.Name = "pBoxScreen2";
            this.pBoxScreen2.Size = new System.Drawing.Size(800, 962);
            this.pBoxScreen2.TabIndex = 1;
            this.pBoxScreen2.TabStop = false;
            this.pBoxScreen2.Click += new System.EventHandler(this.pBoxScreen2_Click);
            this.pBoxScreen2.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxScreen_Paint);
            // 
            // pBoxScreen1
            // 
            this.pBoxScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.pBoxScreen1.Location = new System.Drawing.Point(568, 363);
            this.pBoxScreen1.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxScreen1.Name = "pBoxScreen1";
            this.pBoxScreen1.Size = new System.Drawing.Size(800, 962);
            this.pBoxScreen1.TabIndex = 0;
            this.pBoxScreen1.TabStop = false;
            this.pBoxScreen1.Click += new System.EventHandler(this.pBoxScreen1_Click);
            this.pBoxScreen1.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxScreen_Paint);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2758, 1420);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblwinningScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRoundsWon2);
            this.Controls.Add(this.lblRoundsWon1);
            this.Controls.Add(this.lblRoundsWonPlayer2);
            this.Controls.Add(this.lblRoundsWonPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxRoundsWon);
            this.Controls.Add(this.tBoxScoreBoard);
            this.Controls.Add(this.lblactivePlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pBoxDice);
            this.Controls.Add(this.pBoxTurn);
            this.Controls.Add(this.pBoxWinner1);
            this.Controls.Add(this.pBoxWinner2);
            this.Controls.Add(this.pBoxDiceImg1);
            this.Controls.Add(this.pBoxDiceImg2);
            this.Controls.Add(this.pboxDice2);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.pBoxRunScore1);
            this.Controls.Add(this.lblCumScore2);
            this.Controls.Add(this.lblCumScore1);
            this.Controls.Add(this.pboxDice1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pBoxScreen2);
            this.Controls.Add(this.pBoxScreen1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameForm";
            this.Text = "Groan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRoundsWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWinner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWinner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDiceImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDiceImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRunScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxScreen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxScreen1;
        private System.Windows.Forms.PictureBox pBoxScreen2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox pboxDice1;
        private System.Windows.Forms.Label lblCumScore1;
        private System.Windows.Forms.Label lblCumScore2;
        private System.Windows.Forms.PictureBox pBoxRunScore1;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Label lblRunningScore;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.PictureBox pboxDice2;
        private System.Windows.Forms.PictureBox pBoxDiceImg2;
        private System.Windows.Forms.PictureBox pBoxDiceImg1;
        private System.Windows.Forms.PictureBox pBoxWinner2;
        private System.Windows.Forms.PictureBox pBoxWinner1;
        private System.Windows.Forms.PictureBox pBoxTurn;
        private System.Windows.Forms.PictureBox pBoxDice;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblactivePlayer;
        private System.Windows.Forms.TextBox tBoxScoreBoard;
        private System.Windows.Forms.PictureBox pBoxRoundsWon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoundsWonPlayer1;
        private System.Windows.Forms.Label lblRoundsWonPlayer2;
        private System.Windows.Forms.Label lblRoundsWon1;
        private System.Windows.Forms.Label lblRoundsWon2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblwinningScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ContinueButton;
    }
}

