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


         public class WeightConverter {


            public int FinalPoundsToKilogramsConvertedValue { get; set; }

            public string FinalPoundsToOuncesConvertedValue { get; set; }

            public string FinalPoundsToGramsConvertedValue { get; set; }


            public void PoundsToKiloGramsMethod()
            {

            }

            public void PoundsToOuncesMethod()
            {

            }

            public void PoundsToGramsMethod()
            {

            }

            public void TestMethod()
            {
                string message = "test";
                MessageBox.Show(message);


            }

            public string TestMathMethod(int firstNumber, int secondNumber)
            {



                //*I CAN CONVERT FROM HERE THEN RETURN A STRING*//

                int answer;
                string answerout;

                answer = firstNumber - secondNumber;

                // string answer2 = Convert.ToString(answer);

                answerout = Convert.ToString(answer);


               MessageBox.Show(answer.ToString());
        
                return answerout;

                //How do we access this return value and attach it to a textbox?

            }

           

        }


        class PoundsToKiloGrams : WeightConverter{



            }


        class PoundsToOunces : WeightConverter
            {



            }


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
            PoundsToKiloGrams myObj = new PoundsToKiloGrams();
            myObj.TestMethod();



            //(ITEM -1) We need to find a way to convert this INT into a String so we can attach
            //it to one of the Text Labels
            KiloGramsTextBox.Text = myObj.TestMathMethod(66,6);
            



        }
    }
}
