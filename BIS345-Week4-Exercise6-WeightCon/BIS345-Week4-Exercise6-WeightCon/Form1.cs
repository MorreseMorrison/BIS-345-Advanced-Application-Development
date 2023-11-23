using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS345_Week4_Exercise6_WeightCon
{
    public partial class Form1 : Form
    {


        //(Class - 1P) [Parent], [Abstract], [3 Methods]
         public class WeightConverter {

            public void PoundsToOuncesMethod()
            {

            }

            public void PoundsToGramsMethod()
            {

            }

            public string PoundsToKilogramsMethod(double InputNumber)
            {
                //*(Method - 1) = Pounds To Kilograms Method. This Method, When Called Will Receive An Input
                //From An Object That Is Created From The Child Class "class PoundsToKilograms", That User Input
                //Is Then Fed Into This Method As Type "double InputNumber). InputNumber Is Then Multiplied
                //By 0.454, And Fed Into The "Answer" Variable Which Is Of Type Double. "Answer" Is Then Converted
                //To A String And Assigned To The Return Variable "Answerout". From There That Value Is Printed To
                //The "KiloGramsTextBox.Text" Text Box.

                //**2 Variables**//
                double Answer; //This Variable Is Assigned After The Input Number From The User Is Multiplied By 0.454
                string Answerout; //This Variable Is The Return Variable Of This Function Which Is Of Type String
                //**2 Variables**//

                //**CALCULATION**//

                //(Code Block - 1)
                Answer = InputNumber * 0.454;

                //(Code Block - 2)
                Answerout = Convert.ToString(Answer);

                //**END CALCULATION**//

                //(Code Block -3)
                return Answerout;

            }

          }

        //(Class - 1C) [Child Of WeightConverter Parent Class]

        class PoundsToKiloGrams : WeightConverter{



            }

        //(Class - 2C) [Child Of WeightConverter Parent Class]
        class PoundsToOunces : WeightConverter
            {



            }

        //(Class - 3C) [Child Of WeightConverter Parent Class]
        class PoundsToGrams : WeightConverter
             {

           

             }


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {


            double UserPoundValueInput = double.Parse(UserPoundValueEnterTextBox.Text);


            PoundsToKiloGrams KiloGramObject = new PoundsToKiloGrams();


            KiloGramsTextBox.Text = KiloGramObject.PoundsToKilogramsMethod(UserPoundValueInput);
            


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //(Button - 2 Clear Button) = This Clears All Of The Text Boxes **//
            UserPoundValueEnterTextBox.Text = String.Empty;
            KiloGramsTextBox.Text = String.Empty;
            OuncesTextBox.Text = String.Empty;
            GramsTextBox.Text = String.Empty;

        }
    }
}
