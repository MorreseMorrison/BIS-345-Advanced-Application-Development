using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arithmetic
{
    public partial class btnSubtract : Form
    {
        public btnSubtract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int integerAnswer;

            firstNumber = 10;
            secondNumber = 32;

            integerAnswer = firstNumber + secondNumber;

            //or integerAnswer = 10 + 32;
            //or integerAnswer = firstNumber + 32;
            //integerAnswer = firstNumber + secondNumber + thirdNumber;


            MessageBox.Show(integerAnswer.ToString());
        }

        private void btnAddFloats_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            int integerAnswer;

            firstNumber = 10.5F;
            secondNumber = 99.5F;

            //(2) Adding floats into a INT variable will not work, the following will not work
            //(2)integerAnswer = firstNumber + secondNumber;
            //(2) You should get 109
            integerAnswer = (int)firstNumber + (int)secondNumber;



            MessageBox.Show(integerAnswer.ToString());

            //(1) If You Are Only Adding Float
            //(1)floatAnswer = firstNumber + secondNumber;
            //(1)MessageBox.Show("Your Answer is" + floatAnswer.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int answerSubtract;

            //You can not place a float in an int varible so 50 -25.5 will not work
            answerSubtract = 50 - 25;

            // This will work as well
            //answerSubtract = 50 - numberOne;



            MessageBox.Show(answerSubtract.ToString());
        }
    }
}
