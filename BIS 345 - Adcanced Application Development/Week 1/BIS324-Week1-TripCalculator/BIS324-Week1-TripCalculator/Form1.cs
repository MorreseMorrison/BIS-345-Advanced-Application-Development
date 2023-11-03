using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS324_Week1_TripCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FORM BUTTON = **CLEAR BUTTON**//
            //*EXTRA* Logic To Clear Both Text Boxes. During Run Time The User May
            //Enter In Text Within The And Can Clear If Need Be Once They Click
            //On The Button.
     
            TextBox3EnterDestination.Text = String.Empty;
            TextBox4EnterMiles.Text = String.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1Calculate_Click(object sender, EventArgs e)
        {
            //FORM BUTTON = **CALCULATE**//
            //**MAIN LOGIC**//


        }
    }
}
