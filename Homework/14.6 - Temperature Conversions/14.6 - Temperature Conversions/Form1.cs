using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._6___Temperature_Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tempConvert(object sender, EventArgs e)
        {
            double userInput;
            if(double.TryParse(farIn.Text, out userInput))
            {
                celOut.Text =  $"{((userInput - 32) * (5.0 / 9.0)):N1}°C";
            }
            else
            {
                celOut.Text = "Please enter a valid value...";
            }
        }
    }
}
