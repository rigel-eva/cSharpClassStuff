using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._8._22
{
    public partial class Form1 : Form
    {
		int result = 0;
		int operation = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            display.Text += (sender as Button).Text.ToString();
        }
		private void operator_Click(object sender, EventArgs e)
		{
			int toPut = Convert.ToInt32(display.Text.ToString());//Right, for our own sanity, we are just converting the display to a string
			display.Clear();//Now we have that out of the way, we need to clear the screen.
			switch (operation)
			{
				case 0://Addition
					result += toPut;
					break;
				case 1://Subtraction
					result -= toPut;
					break;
				case 2://Multiplication
					result *= toPut;
					break;
				case 3://Divisionn
					result /= toPut;
					break;
			}
			switch ((sender as Button).Name)
			{
				case "add":
					operation = 0;
					break;
				case "subtract":
					operation = 1;
					break;
				case "multiply":
					operation = 2;
				break;
				case "divide":
					operation = 3;
					break; ;
			}	
		}
		private void displayResult(object sender, EventArgs e)
		{
			operator_Click(sender, null);//We kinda have to send a button to prevent a crash ... so ... crap.
			display.Text = result.ToString();//Right first thing first, put the result in the text box
			result = 0;//Then Clear out the result
			operation = 0;//And make it so that the operation is going to add it.
		}
        private void clearScreen(object sender, EventArgs e)
        {
            display.Clear();
        }
        private void clearData(object sender, EventArgs e)
        {
			//Alright Let's zero out the result, and the operation, and clear out the display
			result = 0;
			operation = 0;
			display.Clear();
        }
    }
}
