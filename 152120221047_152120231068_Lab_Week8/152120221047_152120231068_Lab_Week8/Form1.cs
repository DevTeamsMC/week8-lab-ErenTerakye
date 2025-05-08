using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve selected difficulty, theme, and category
            string selectedDifficulty = GetSelectedDifficulty();
            string selectedTheme = GetSelectedTheme();
            string selectedCategory = GetSelectedCategory();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Pass the current Form1 instance to Form2
            Form2 f2 = new Form2(this, selectedCategory, selectedDifficulty, (int)numericUpDownTime.Value, selectedTheme)
            {
                SelectedDifficulty = selectedDifficulty,
                SelectedImageType = selectedTheme,
                SelectedCategory = selectedCategory
            };

            this.Hide(); // Hide the current Form1 instance
            f2.ShowDialog();
            this.Show();
        }


        private string GetSelectedDifficulty()
        {
            if (radioButtonEasy.Checked)
                return "Easy";
            if (radioButtonMedium.Checked)
                return "Medium";
            if (radioButtonHard.Checked)
                return "Hard";

            return "Easy";
        }

        private string GetSelectedTheme()
        {
            if (radioButtonHangman.Checked)
                return "Hangman";
            if (radioButtonStickman.Checked)
                return "Stickman";
            if (radioButtonFlower.Checked)
                return "Flower";

            return "Hangman";
        }

        private string GetSelectedCategory()
        {
            if (radioButtonHistory.Checked)
                return "History";
            if (radioButtonGeography.Checked)
                return "Geography";
            if (radioButtonMath.Checked)
                return "Math";
            if (radioButtonTrivia.Checked)
                return "Trivia";
            if (radioButtonMixed.Checked)
                return "Mixed";

            return "Mixed";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            labelTime.Visible = !labelTime.Visible;
            numericUpDownTime.Visible = !numericUpDownTime.Visible;
            groupBoxCategory.Visible = !groupBoxCategory.Visible;
            groupBoxTheme.Visible = !groupBoxTheme.Visible;
            groupBoxDifficulty.Visible = !groupBoxDifficulty.Visible;
            buttonMainMenu.Visible = !buttonMainMenu.Visible;
            button1.Visible = !button1.Visible;
            buttonSettings.Visible = !buttonSettings.Visible;
            label1.Visible = !label1.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.cover2;
            label1.Visible = !label1.Visible;
            buttonMainMenu.Visible = !buttonMainMenu.Visible;
            button1.Visible = !button1.Visible;
            buttonSettings.Visible = !buttonSettings.Visible;
            labelTime.Visible = !labelTime.Visible;
            numericUpDownTime.Visible = !numericUpDownTime.Visible;
            groupBoxCategory.Visible = !groupBoxCategory.Visible;
            groupBoxTheme.Visible = !groupBoxTheme.Visible;
            groupBoxDifficulty.Visible = !groupBoxDifficulty.Visible;
        }
    }
}
