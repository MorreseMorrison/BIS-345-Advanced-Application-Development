using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
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

        private void button1_Click(object sender, EventArgs e)
        {
            int myInteger;

            myInteger = 25;

            MessageBox.Show(myInteger.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float myfloat;

            //Try to run your programme again. You'll get an error message, and a blue 
            //wiggly line under your code. Because you've missed the F out, 
            //C# has defaulted to using a double value for your number. 
            //A float variable can't hold a double value, confirming 
            //that C# is a strongly typed language. (The opposite is a weakly typed language.
            //PHP, and JavaScript are examples of weakly typed languages 
            //- you can store any kind of values in the variables you set up.)
            myfloat = 0.42F;

            MessageBox.Show(myfloat.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double myDouble;

            myDouble = 0.007;

            MessageBox.Show(myDouble.ToString());
        }
    }
}
