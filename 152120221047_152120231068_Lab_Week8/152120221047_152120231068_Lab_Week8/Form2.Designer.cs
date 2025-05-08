using System.Drawing;
using System.Windows.Forms;
using System;

namespace hangman
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblClue;
        private Label lblWord;
        private Label lblWordLength;
        private Label lblPoints;
        private Label lblIncorrectLetters;
        private TextBox txtGuess;
        private Button btnGuess;
        private Button btnEndGame;
        private PictureBox pictureBoxHangman;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClue = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblIncorrectLetters = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClue
            // 
            this.lblClue.Location = new System.Drawing.Point(17, 16);
            this.lblClue.Name = "lblClue";
            this.lblClue.Size = new System.Drawing.Size(300, 20);
            this.lblClue.TabIndex = 0;
            // 
            // lblWord
            // 
            this.lblWord.Location = new System.Drawing.Point(17, 36);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(300, 20);
            this.lblWord.TabIndex = 1;
            this.lblWord.Click += new System.EventHandler(this.lblWord_Click);
            // 
            // lblWordLength
            // 
            this.lblWordLength.Location = new System.Drawing.Point(17, 76);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(300, 20);
            this.lblWordLength.TabIndex = 2;
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(385, 30);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(203, 20);
            this.lblPoints.TabIndex = 3;
            // 
            // lblIncorrectLetters
            // 
            this.lblIncorrectLetters.Location = new System.Drawing.Point(17, 56);
            this.lblIncorrectLetters.Name = "lblIncorrectLetters";
            this.lblIncorrectLetters.Size = new System.Drawing.Size(300, 20);
            this.lblIncorrectLetters.TabIndex = 4;
            this.lblIncorrectLetters.Click += new System.EventHandler(this.lblIncorrectLetters_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(20, 99);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 5;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(126, 99);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(20, 125);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(100, 23);
            this.btnEndGame.TabIndex = 7;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Location = new System.Drawing.Point(388, 88);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHangman.TabIndex = 8;
            this.pictureBoxHangman.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(385, 14);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 16);
            this.lblTimer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(385, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(50, 16);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "label2";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(385, 62);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 16);
            this.lblDifficulty.TabIndex = 12;
            this.lblDifficulty.Text = "label3";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblClue);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblWordLength);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblIncorrectLetters);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.pictureBoxHangman);
            this.Name = "Form2";
            this.Text = "Hangman Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Leave += new System.EventHandler(this.Form2_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblTimer;
        private Label label1;
        private Timer timer1;
        private Label lblCategory;
        private Label lblDifficulty;
    }
}
