using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._9._26___Craps
{
    public partial class Form1 : Form
    {
        Random generator;
        int point;
        public Form1()
        {
            InitializeComponent();//RUN THIS FIRST FOR THE LOVE OF GOD
            generator = new Random();
            point = -1;
            //diceDisplay.Hide();
            pointBox.Hide();
            messages.Hide();
        }
        public Tuple<int,int,int> roll()//Well ain't this nice.
        {
            int dice1 = generator.Next(1, 6);
            int dice2 = generator.Next(1, 6);
            return new Tuple<int,int,int>(dice1 + dice2, dice1, dice2);
        }
        public int rollDice()
        {
            Tuple<int, int, int> diceRoll = roll();
            diceDisplay.Text = diceRoll.Item2.ToString() + "+" + diceRoll.Item3.ToString() + "=" + diceRoll.Item1.ToString();
            return diceRoll.Item1;//Honestly should have written this function from the start, but I really, REALLY wanted to play with Tuples ...
        }
        private void gameStart(object sender, EventArgs e)
        {
            //gameSetup
            messages.Hide();
            Tuple<int, int, int> diceRoll = roll();
            diceDisplay.Text = diceRoll.Item2.ToString() + "+" + diceRoll.Item3.ToString()+"="+diceRoll.Item1.ToString();
            if (diceRoll.Item1 == 7 || diceRoll.Item1 == 11)//Winner!
            {
                messages.Text = "Winner!";
                messages.Show();
                actionButton.Text = "Play Again?";
            }
            else if(diceRoll.Item1 == 2 || diceRoll.Item1 == 3 || diceRoll.Item1 == 12)//Looser
            {
                messages.Text = "Loser!";
                messages.Show();
                actionButton.Text = "Play Again?";
            }
            else//Point established!
            {
                point = diceRoll.Item1;
                messages.Text = "Point Set!:";
                pointBox.Text = diceRoll.Item1.ToString();
                messages.Show();
                pointBox.Show();
                actionButton.Text = "Roll!";
                this.actionButton.Click -= new System.EventHandler(this.gameStart);
                this.actionButton.Click += new System.EventHandler(this.reroll);
            }
        }
        private void reroll(object sender, EventArgs e)
        {
            int total = rollDice();
            if (total == 7)
            {
                messages.Text = "You Lose.";
                replay();
            }
            else if(total == point){
                messages.Text = "You Win!";
                replay();
            }
        }
        private void replay()
        {
            this.actionButton.Click += new System.EventHandler(this.gameStart);
            this.actionButton.Click -= new System.EventHandler(this.reroll);
            actionButton.Text = "Play Again?";
        }
    }
}
