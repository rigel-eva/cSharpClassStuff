using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._8._22
{
    public partial class Form1 : Form
    {
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

        private void clearScreen(object sender, EventArgs e)
        {
            display.Clear();
        }
        private void clearData(object sender, EventArgs e)
        {

        }
    }
}
