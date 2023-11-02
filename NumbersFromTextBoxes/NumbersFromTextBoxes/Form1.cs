using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersFromTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int answer;

            //is says, find a text box called tbFirstNumber. Access its Text property. 
            //When the Text property is retrieved, store it in the variable 
            //called firstTextBoxNumber.

            //So we need to convert the text from the text box into an integer.
            //The way you do this is to use something called Parsing. 
            //Fortunately, this involves nothing more complex that typing the 
            //word "Parse".You can do different types of Parses.
            //Because we need to convert the text into an integer, 
            //we need an Integer Parse. So change the line to this:
            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);

            answer = firstTextBoxNumber + secondTextBoxNumber;

            MessageBox.Show(answer.ToString());

            //(2) Other Parse Methods
            //float firstTextBoxNumber;
            //firstTextBoxNumber = float.Parse(tbFirstNumber.Text);
             //double firstTextBoxNumber
            //firstTextBoxNumber = double.Parse(tbFirstNumber.Text);

        }
    }
}
