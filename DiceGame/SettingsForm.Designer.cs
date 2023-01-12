
namespace DiceGame
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn2Player = new System.Windows.Forms.RadioButton();
            this.rBtn1Player = new System.Windows.Forms.RadioButton();
            this.tBoxWinScore = new System.Windows.Forms.TextBox();
            this.btnCustomise = new System.Windows.Forms.Button();
            this.btnSetScoreToWin50 = new System.Windows.Forms.Button();
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelReminder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn2Player);
            this.groupBox1.Controls.Add(this.rBtn1Player);
            this.groupBox1.Location = new System.Drawing.Point(483, 618);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(352, 127);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // rBtn2Player
            // 
            this.rBtn2Player.AutoSize = true;
            this.rBtn2Player.Location = new System.Drawing.Point(14, 86);
            this.rBtn2Player.Margin = new System.Windows.Forms.Padding(6);
            this.rBtn2Player.Name = "rBtn2Player";
            this.rBtn2Player.Size = new System.Drawing.Size(122, 29);
            this.rBtn2Player.TabIndex = 1;
            this.rBtn2Player.TabStop = true;
            this.rBtn2Player.Text = "2 Player";
            this.rBtn2Player.UseVisualStyleBackColor = true;
            // 
            // rBtn1Player
            // 
            this.rBtn1Player.AutoSize = true;
            this.rBtn1Player.Location = new System.Drawing.Point(14, 31);
            this.rBtn1Player.Margin = new System.Windows.Forms.Padding(6);
            this.rBtn1Player.Name = "rBtn1Player";
            this.rBtn1Player.Size = new System.Drawing.Size(122, 29);
            this.rBtn1Player.TabIndex = 0;
            this.rBtn1Player.TabStop = true;
            this.rBtn1Player.Text = "1 Player";
            this.rBtn1Player.UseVisualStyleBackColor = true;
            // 
            // tBoxWinScore
            // 
            this.tBoxWinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tBoxWinScore.Location = new System.Drawing.Point(567, 274);
            this.tBoxWinScore.Margin = new System.Windows.Forms.Padding(6);
            this.tBoxWinScore.Name = "tBoxWinScore";
            this.tBoxWinScore.Size = new System.Drawing.Size(196, 98);
            this.tBoxWinScore.TabIndex = 28;
            this.tBoxWinScore.Text = "50";
            this.tBoxWinScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxWinScore.TextChanged += new System.EventHandler(this.tBoxWinScore_TextChanged);
            // 
            // btnCustomise
            // 
            this.btnCustomise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCustomise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.btnCustomise.Location = new System.Drawing.Point(505, 520);
            this.btnCustomise.Margin = new System.Windows.Forms.Padding(6);
            this.btnCustomise.Name = "btnCustomise";
            this.btnCustomise.Size = new System.Drawing.Size(330, 67);
            this.btnCustomise.TabIndex = 26;
            this.btnCustomise.Text = "✍🏻 Customise Score";
            this.btnCustomise.UseVisualStyleBackColor = true;
            this.btnCustomise.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetScoreToWin50
            // 
            this.btnSetScoreToWin50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSetScoreToWin50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.btnSetScoreToWin50.Location = new System.Drawing.Point(453, 420);
            this.btnSetScoreToWin50.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetScoreToWin50.Name = "btnSetScoreToWin50";
            this.btnSetScoreToWin50.Size = new System.Drawing.Size(424, 65);
            this.btnSetScoreToWin50.TabIndex = 25;
            this.btnSetScoreToWin50.Text = "🔥 Set Winning Score to 50";
            this.btnSetScoreToWin50.UseVisualStyleBackColor = true;
            this.btnSetScoreToWin50.Click += new System.EventHandler(this.btnSetScoreToWin50_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReminder.Location = new System.Drawing.Point(432, 647);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(445, 29);
            this.lblReminder.TabIndex = 31;
            this.lblReminder.Text = "‼️ Please choose the amount of players ‼️";
            this.lblReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReminder.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.btnStart.Location = new System.Drawing.Point(576, 705);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 58);
            this.btnStart.TabIndex = 29;
            this.btnStart.Text = "🏃🏻 Start Game !";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // labelReminder
            // 
            this.labelReminder.AutoSize = true;
            this.labelReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelReminder.Location = new System.Drawing.Point(447, 789);
            this.labelReminder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(445, 29);
            this.labelReminder.TabIndex = 33;
            this.labelReminder.Text = "‼️ Please choose the amount of players ‼️";
            this.labelReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReminder.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(15)))), ((int)(((byte)(112)))));
            this.button1.Location = new System.Drawing.Point(679, 852);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 56);
            this.button1.TabIndex = 32;
            this.button1.Text = "🏃🏻 Start Game !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(411, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 694);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(569, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Game Settings";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(530, 59);
            this.lblGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(305, 107);
            this.lblGame.TabIndex = 35;
            this.lblGame.Text = "Groan";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Indigo;
            this.backBtn.Location = new System.Drawing.Point(483, 850);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(163, 58);
            this.backBtn.TabIndex = 36;
            this.backBtn.Text = "<< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiceGame.Properties.Resources.purple_waves_1920x8501;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 1043);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReminder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBoxWinScore);
            this.Controls.Add(this.btnCustomise);
            this.Controls.Add(this.btnSetScoreToWin50);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnStart);
            this.Name = "SettingsForm";
            this.Text = "Settings Form";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn2Player;
        private System.Windows.Forms.RadioButton rBtn1Player;
        private System.Windows.Forms.TextBox tBoxWinScore;
        private System.Windows.Forms.Button btnCustomise;
        private System.Windows.Forms.Button btnSetScoreToWin50;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelReminder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button backBtn;
    }
}