namespace hangman
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.radioButtonMath = new System.Windows.Forms.RadioButton();
            this.radioButtonGeography = new System.Windows.Forms.RadioButton();
            this.radioButtonHistory = new System.Windows.Forms.RadioButton();
            this.radioButtonTrivia = new System.Windows.Forms.RadioButton();
            this.radioButtonMixed = new System.Windows.Forms.RadioButton();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.radioButtonFlower = new System.Windows.Forms.RadioButton();
            this.radioButtonStickman = new System.Windows.Forms.RadioButton();
            this.radioButtonHangman = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.groupBoxDifficulty.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGMAN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(738, 388);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 50);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Exit";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(354, 242);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(104, 37);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Location = new System.Drawing.Point(253, 284);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time";
            this.labelTime.Visible = false;
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(247, 300);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownTime.TabIndex = 8;
            this.numericUpDownTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownTime.Visible = false;
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonMedium);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEasy);
            this.groupBoxDifficulty.Location = new System.Drawing.Point(408, 285);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(79, 94);
            this.groupBoxDifficulty.TabIndex = 9;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Difficulty";
            this.groupBoxDifficulty.Visible = false;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Checked = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(48, 17);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(6, 42);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(6, 65);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(48, 17);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCategory.Controls.Add(this.radioButtonMixed);
            this.groupBoxCategory.Controls.Add(this.radioButtonTrivia);
            this.groupBoxCategory.Controls.Add(this.radioButtonMath);
            this.groupBoxCategory.Controls.Add(this.radioButtonGeography);
            this.groupBoxCategory.Controls.Add(this.radioButtonHistory);
            this.groupBoxCategory.Location = new System.Drawing.Point(298, 285);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(104, 140);
            this.groupBoxCategory.TabIndex = 10;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            this.groupBoxCategory.Visible = false;
            // 
            // radioButtonMath
            // 
            this.radioButtonMath.AutoSize = true;
            this.radioButtonMath.Location = new System.Drawing.Point(6, 65);
            this.radioButtonMath.Name = "radioButtonMath";
            this.radioButtonMath.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMath.TabIndex = 2;
            this.radioButtonMath.Text = "Math";
            this.radioButtonMath.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeography
            // 
            this.radioButtonGeography.AutoSize = true;
            this.radioButtonGeography.Location = new System.Drawing.Point(6, 42);
            this.radioButtonGeography.Name = "radioButtonGeography";
            this.radioButtonGeography.Size = new System.Drawing.Size(77, 17);
            this.radioButtonGeography.TabIndex = 1;
            this.radioButtonGeography.Text = "Geography";
            this.radioButtonGeography.UseVisualStyleBackColor = true;
            // 
            // radioButtonHistory
            // 
            this.radioButtonHistory.AutoSize = true;
            this.radioButtonHistory.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHistory.Name = "radioButtonHistory";
            this.radioButtonHistory.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHistory.TabIndex = 0;
            this.radioButtonHistory.Text = "History";
            this.radioButtonHistory.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrivia
            // 
            this.radioButtonTrivia.AutoSize = true;
            this.radioButtonTrivia.Location = new System.Drawing.Point(6, 88);
            this.radioButtonTrivia.Name = "radioButtonTrivia";
            this.radioButtonTrivia.Size = new System.Drawing.Size(51, 17);
            this.radioButtonTrivia.TabIndex = 3;
            this.radioButtonTrivia.Text = "Trivia";
            this.radioButtonTrivia.UseVisualStyleBackColor = true;
            // 
            // radioButtonMixed
            // 
            this.radioButtonMixed.AutoSize = true;
            this.radioButtonMixed.Checked = true;
            this.radioButtonMixed.Location = new System.Drawing.Point(6, 111);
            this.radioButtonMixed.Name = "radioButtonMixed";
            this.radioButtonMixed.Size = new System.Drawing.Size(53, 17);
            this.radioButtonMixed.TabIndex = 4;
            this.radioButtonMixed.TabStop = true;
            this.radioButtonMixed.Text = "Mixed";
            this.radioButtonMixed.UseVisualStyleBackColor = true;
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTheme.Controls.Add(this.radioButtonFlower);
            this.groupBoxTheme.Controls.Add(this.radioButtonStickman);
            this.groupBoxTheme.Controls.Add(this.radioButtonHangman);
            this.groupBoxTheme.Location = new System.Drawing.Point(493, 285);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(107, 94);
            this.groupBoxTheme.TabIndex = 10;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "Theme";
            this.groupBoxTheme.Visible = false;
            // 
            // radioButtonFlower
            // 
            this.radioButtonFlower.AutoSize = true;
            this.radioButtonFlower.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFlower.Name = "radioButtonFlower";
            this.radioButtonFlower.Size = new System.Drawing.Size(88, 17);
            this.radioButtonFlower.TabIndex = 2;
            this.radioButtonFlower.Text = "Flower Petals";
            this.radioButtonFlower.UseVisualStyleBackColor = true;
            // 
            // radioButtonStickman
            // 
            this.radioButtonStickman.AutoSize = true;
            this.radioButtonStickman.Location = new System.Drawing.Point(6, 42);
            this.radioButtonStickman.Name = "radioButtonStickman";
            this.radioButtonStickman.Size = new System.Drawing.Size(98, 17);
            this.radioButtonStickman.TabIndex = 1;
            this.radioButtonStickman.Text = "Stick Hangman";
            this.radioButtonStickman.UseVisualStyleBackColor = true;
            // 
            // radioButtonHangman
            // 
            this.radioButtonHangman.AutoSize = true;
            this.radioButtonHangman.Checked = true;
            this.radioButtonHangman.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHangman.Name = "radioButtonHangman";
            this.radioButtonHangman.Size = new System.Drawing.Size(71, 17);
            this.radioButtonHangman.TabIndex = 0;
            this.radioButtonHangman.TabStop = true;
            this.radioButtonHangman.Text = "Hangman";
            this.radioButtonHangman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hangman.Properties.Resources.cover2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTheme);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonMath;
        private System.Windows.Forms.RadioButton radioButtonGeography;
        private System.Windows.Forms.RadioButton radioButtonHistory;
        private System.Windows.Forms.RadioButton radioButtonMixed;
        private System.Windows.Forms.RadioButton radioButtonTrivia;
        private System.Windows.Forms.GroupBox groupBoxTheme;
        private System.Windows.Forms.RadioButton radioButtonFlower;
        private System.Windows.Forms.RadioButton radioButtonStickman;
        private System.Windows.Forms.RadioButton radioButtonHangman;
    }
}

