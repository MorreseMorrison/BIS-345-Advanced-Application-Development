using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Morrese Morrisonn
//BIS 345 - Advanced Application Development
//University: Peirce College
//Professor: Dr Nathan Kilgore
//Date & Time Completed: 11/3/2023 at 1:42PM
//Progream Description: This Program Is A Trip Calculator. The User Will Enter Their Destination & Miles Traveled
//From There The Program Will Execute Logic to Show The User Their MPG. The User Has Been Assigned A Honda Accord
//With A Set Tank Capacity of 14.8.

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
            //Attention: This Label Is Hidden At The Bottom Of The Form On The Left Hand Side Directl Below The Clear Button
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

            //VARIABLES 
            string DestinationTraveled; //This Variable Will Contain An Input From The User When Asked Their Destination
            double HondaGallonCapacity = 14.8; //This Varible Is Set To 14.8 As This Is The Tank Capacity For The 2023 Honda Accord
            double HondaMaximumMileageOneFullTank = 653; //Maximum Mileage Of The Listed 2023 Honda Accord
            double MilesTraveled; //This Variable Will Contain An Input From The User When Asked Of Their Miles Traveled
            double MilesPerGallon; //This Varable Will Contain The End Value For The MPG Logic Calculation In Code Block - 3
             


            //**PROGRAM START**//

            //(Code Block-1) Text From The "Please Type In Your Destination:" Question Is Entered
            //And Stored In "String Variable DestinationTraveled"
            DestinationTraveled = TextBox3EnterDestination.Text;


            //(Code Block-2)Text From The "Please Enter Miles Traveled: Question Is Entered And Stored In "Double Variable MilesTraveled"
            //**Also, We Are Utilizing The Parse Converter To Convert The String Into Type Double So That It May Be Used In Our MPG Logic Calculation**

            MilesTraveled = double.Parse(TextBox4EnterMiles.Text);

            //(Code Block-2.1)If Logic In The Event A User Enters A Value Greater Then The Maximum Mileage Of One Full Tank On A Honda Accord.
            if (MilesTraveled > HondaMaximumMileageOneFullTank) {

                //Message Box Will Appear With An "OK" Button
                MessageBox.Show("THE MAXIMUM MILES THAT CAN BE TRAVELED ON ONE TANK OF GAS IS 653 Miles. Please Try Again", "PLEASE TRY AGAIN", MessageBoxButtons.OK);

                //After Selecting Ok The Program Will Restart, Clearing All Fields
                Application.Restart();
            }



            //(Code Block-4) Miles Per Gallon Logic:
            //Pseudo Code: Total Miles Traveled Divided By The Car's Gallon Capacity = MPG
            //This Operand Is Utilized For Accuracy / Instead Of %
            MilesPerGallon = MilesTraveled / HondaGallonCapacity;

          

            //(Code Block-4) Print Out Of The Destination: Traveled As Well As The MPG In Precision Format. This Is Being Fed To A Hidden Label At The Bottom Of The Form
            Label3MpgOutput.Text = String.Format("You Traveled To " + DestinationTraveled + "! Your MPG For This Trip Was " + MilesPerGallon.ToString("0.00") + " Miles!" );

            //**END**//
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           

          


        }
    }
}
