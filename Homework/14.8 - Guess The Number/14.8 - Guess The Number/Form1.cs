using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._8___Guess_The_Number
{
    public partial class Form1 : Form
    {

        int number;
        Random rnd;
        public Form1()
        {
            rnd = new Random();
            InitializeComponent();
        }
        void regenerate()//Handles Reseting stuff
        {
            number = rnd.Next(1, 1000);
            this.BackColor = Form1.DefaultBackColor;
            gameInfo.Visible = true;
            feedback.Visible = false;
            actingButton.Text = "Guess";
            inputBox.Text = "";
            inputBox.Enabled = true;
            this.actingButton.Click -= new System.EventHandler(this.regenerate);
            this.actingButton.Click += new System.EventHandler(this.runCheck);
        }
        void regenerate(object sender, EventArgs e)//Allows us to set this as an event handler
        {
            regenerate();
        }
        void guess(int guess)
        {
            if (guess > number)
            {
                feedback.Text = "Too High!";
            }
            else if (guess < number)
            {
                feedback.Text = "Too Low!";
            }
            else//They got the number
            {
                feedback.Text = "Correct!";
                this.BackColor = Color.Green;
                inputBox.Enabled = false;
                actingButton.Text = "Replay?";
                this.actingButton.Click -= new System.EventHandler(this.runCheck);
                this.actingButton.Click += new System.EventHandler(this.regenerate);
                return;//We don't want to execute the rest of the code here ...
            }
            if (Math.Abs(guess - number) < 230)//If we are within spitting distance of it and not at a value that makes the window freaking black
            {
                this.BackColor = Color.FromArgb(255 - Math.Abs(guess - number),0,0);
            }
            else//Otherwise ...
            {
                this.BackColor = Color.Blue;//Just make it blue ... no sense in making it darker otherwise ...
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            regenerate();//Generates our random number
        }

        private void runCheck(object sender, EventArgs e)
        {
            runCheck();
        }

        private void runCheck(object sender, KeyEventArgs e)//This allows us to use enter as a valid input for this (thank god)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runCheck();
            }
        }
        private void runCheck()
        {
            int userGuess;
            if (int.TryParse(inputBox.Text, out userGuess))
            {
                gameInfo.Visible = false;
                feedback.Visible = true;
                guess(userGuess);
            }
        }
    }
}
