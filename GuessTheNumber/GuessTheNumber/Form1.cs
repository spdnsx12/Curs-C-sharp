using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessTheNumber : Form
    {
        int randomNumber;
        int triesCount = 0;
        bool isNumeric;
        

        public GuessTheNumber()
        {
            InitializeComponent();
            initialize();
        }

        public void initialize()
        {
            if (triesCount > 0)
            {
                infoMsg.Text = "";
                numberBox.Text = "";
                gameInfo.Text = "Numarul este intre 0 si 10";
                radioButtonDa.Hide();
                radioButtonNu.Hide();
                guessButton.Show();
            }
            else
            {
                randomNumber = new Random().Next(0, 10);
                triesCount = 0;
                radioButtonDa.Hide();
                radioButtonNu.Hide();
                numberBox.Text = "";
                gameInfo.Text = "Numarul este intre 0 si 10";
                guessButton.Text = "Guess";
            }
        }
        private void guessButton_Click(object sender, EventArgs e)
        {

            if (guessButton.Text == "New Number")
            {
                infoMsg.Text = "";
                triesCount = 0;
                initialize();
            }
            else
            {
                checkNumber();
            }
        }


        public void checkNumber()
        {
            triesCount++;
            isNumeric = int.TryParse(numberBox.Text, out _);
            if (isNumeric == false)
            {
                infoMsg.Text = "Nu ai introdus un numar";
                numberBox.Text = "";
                triesCount--;
            }
            else if (randomNumber == int.Parse(numberBox.Text))
            {
                if (triesCount == 1)
                {
                    infoMsg.Text = "Felicitari, ai ghicit din prima incercare!";
                    guessButton.Text = "New Number";
                }
                else
                {
                    infoMsg.Text = "Felicitari, ai ghicit din " + triesCount.ToString() + " incercari!";
                    guessButton.Text = "New Number";
                }

            }
            else if (randomNumber > int.Parse(numberBox.Text))
            {
                gameInfo.Text = "Incearca o valoare mai mare!";
                infoMsg.Text = "Nu ai ghichit! Vrei sa mai incerci?";
                guessButton.Hide();
                anotherTry();
            }
            else
            {
                gameInfo.Text = "Incearca o valoare mai mica!";
                infoMsg.Text = "Nu ai ghichit! Vrei sa mai incerci?";
                guessButton.Hide();
                anotherTry();
            }
        }

        public void anotherTry()
        {
            radioButtonDa.Show();
            radioButtonNu.Show();
            radioButtonDa.Checked = false;
            radioButtonNu.Checked = false;
            //numberBox.Enabled = false;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (sender as RadioButton);
            if (radioButton.Text == "Da")
            {
                //numberBox.Enabled = true;
                initialize();
            }
            else
            {
                infoMsg.Text = "La revedere";
                GuessTheNumber.ActiveForm.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
