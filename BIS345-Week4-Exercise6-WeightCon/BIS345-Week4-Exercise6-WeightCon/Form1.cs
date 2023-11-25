using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Morrese Morrison
//Date Completed: 11/24/2023 6:51PM
//University: Peirce College
//Course: BIS 345 Advanced Application Development
//Professor: Dr. Nathan Kilgore
//Program Description: This Program Converts A Pound Value Into Kilograms, Ounces, And Grams. From The Please Enter TextBox
//A Value Is Entered. The Value Can Not Be Negative Or Zero. There Is An If Statement That Is In Place To Handle That Non Valid Value Submission.
//In Addition There Is A Try Catch Exception Handle When A User Attempts To Enter Anything Other Then A Number, As Well As Entering Nothing At All.
//Once A Valid Value Is Submitted, That Value Is Then Fed Into Three Functions, To Generate The Final Conversion Value For Kilograms, Grams And Ounces.
//This Program Also Consists Of 1 Abstract Parent Class, And Three Child Classess Derived From The Parent Class. Within The Parent Class, There Are
//Three Methods That Complete The Pounds To Kilograms, Grams, and Ounces Conversion. All Three Methods Have A String Return Value That Is Then
//Placed In The Appropriate Text Label.

namespace BIS345_Week4_Exercise6_WeightCon
{
    public partial class Form1 : Form
    {

        //[** START CLASSES**]//

        //Parent Class: 1
        //Child Classess: 3

        //(Class - 1P) [Parent], [Abstract], [3 Methods]

         public class WeightConverter {

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

            public string PoundsToOuncesMethod(double InputNumber)
            {
                //*(Method - 2) = Pounds To Ounces Method. This Method, When Called Will Receive An Input
                //From An Object That Is Created From The Child Class "class PoundsToOunces", That User Input
                //Is Then Fed Into This Method As Type "double InputNumber". InputNumber Is Then Multiplied
                //By 16, And Fed Into The "Answer" Variable Which Is Of Type Double. "Answer" Is Then Converted
                //To A String And Assigned To The Return Variable "Answerout". From There That Value Is Printed To
                //The "KiloGramsTextBox.Text" Text Box.

                //**2 Variables**//
                double Answer; //This Variable Is Assigned After The Input Number From The User Is Multiplied By 16
                string Answerout; //This Variable Is The Return Variable Of This Function Which Is Of Type String
                //**2 Variables**//


                //**CALCULATION**//

                //(Code Block - 1)
                Answer = InputNumber * 16;

                //(Code Block - 2)
                Answerout = Convert.ToString(Answer);


                //**END CALCULATION**//

                //(Code Block -3)
                return Answerout;

            }

            public string PoundsToGramsMethod(double InputNumber)
            {
                //*(Method - 3) = Pounds To Grams Method. This Method, When Called Will Receive An Input
                //From An Object That Is Created From The Child Class "class GramsToKilograms", That User Input
                //Is Then Fed Into This Method As Type "double InputNumber". InputNumber Is Then Multiplied
                //By 453.592, And Fed Into The "Answer" Variable Which Is Of Type Double. "Answer" Is Then Converted
                //To A String And Assigned To The Return Variable "Answerout". From There That Value Is Printed To
                //The "GramsTextBox.Text" Text Box.

                //**2 Variables**//
                double Answer; //This Variable Is Assigned After The Input Number From The User Is Multiplied By 453.592
                string Answerout; //This Variable Is The Return Variable Of This Function Which Is Of Type String
               //**2 Variables**//

                //**CALCULATION**//

                //(Code Block - 1)
                Answer = InputNumber * 453.592;

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

        //[**END CLASSESS**]//


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            //**Main Logic**//


            //Try Catch Exception Handling Method, Try Catch Is Looking For System.FormatException, When A Letter, Or Nothing
            //Is Entered Into The UserPoundValueEnterTextBox, If The Exception Occurs, The Catch Portion Will Print An Error Message
            try
            {

                //(Code Block - 1 - START) This Code Takes The User's Input From The "Please Enter The Pound Weight Value"//
                //This Value Is Parsed Into A Double Value And Assigned To The "UserPoundValueInput" variable//
                double UserPoundValueInput = double.Parse(UserPoundValueEnterTextBox.Text);
               


                    //(Code Block 1.2) This If Statement Test Of The Entered Value Is A Negative Number Or Equal To Zero, If This Is
                    //True, The Message Box Will Appear, And The Program Will Restart
                    if (UserPoundValueInput <= 0)
                    {

                        MessageBox.Show("You Can Not Enter A Zero Or A Negative Value, Please Try Again");
                        Application.Restart();

                    }


                //(Code Block - 1 - END)//


                //(Code Block - 2 START)//
                //(2.1 - Object Creation)//
                PoundsToKiloGrams KiloGramObject = new PoundsToKiloGrams();

                //(2.2 - Object "KiloGramObject" Calling The Pounds To KiloGramsMethod With Parameter. Returns To The KiloGramsTextBox)//
                KiloGramsTextBox.Text = KiloGramObject.PoundsToKilogramsMethod(UserPoundValueInput);
                //(Code Block - 2 - END)//



                //(Code Block - 3 START)//
                //(3.1 - Object Creation)//
                PoundsToOunces OuncesObject = new PoundsToOunces();

                //(3.1 - Object "OuncesObject" Calling The Pounds To Ounces Method With Parameter. Returns To The OuncesTextBox)//
                OuncesTextBox.Text = OuncesObject.PoundsToOuncesMethod(UserPoundValueInput);
                //(Code Block - 3 - END)//



                //(Code Block - 4 START)//
                //(4.1 - Object Creation)//
                PoundsToGrams GramsObject = new PoundsToGrams();

                //(4.2 - Object "GramsObject" Calling The PoundsToGramsMethod With Parameter. Returns To The GramsTextBox)//
                GramsTextBox.Text = GramsObject.PoundsToGramsMethod(UserPoundValueInput);
                //(Code Block - 4 - END)//

            }


            catch (System.FormatException)
            {

                MessageBox.Show("You Did Not Enter A Number Value, Please Try Again");

            }



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
