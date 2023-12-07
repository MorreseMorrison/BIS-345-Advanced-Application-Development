using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Input Out Put Library
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS345_Week5_Exercise9_EmpPayroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //(Part - 1 - PAYROLL CALCULATION SECTION)
        private void PayRollCalculationSectionButton_Click(object sender, EventArgs e)
        {
            //**MAIN LOGIC**\\


            //VARIABLES
            String EmployeeFullNameEnter;
            String EmployeeIDEnter;
            double EmployeePayRateEnter;
            double EmployeeHoursWorkedEnter;


            //**PROGRAM START**//


            //**PAYROLL CALCULATION SECTION START**\\
            try
            {

                //(Code Block - 1) = User Enter Values Via Text Labels
                EmployeeFullNameEnter = EnterFullNameTextBox.Text;
                EmployeeIDEnter = EnterEmployeeIDTextBox.Text;
                EmployeePayRateEnter = double.Parse(EnterPayrateTextbox.Text);
                EmployeeHoursWorkedEnter = double.Parse(EnterHoursWorkedTextbox.Text);


                //(Code Block - 2) = If Statements Then Execution Within Try Catch Block

                //(Code Block - 2.1)\\

                //**IF STATEMENT**\\ If The Rate Entered Is Greater Than or Equal To 50, Print Error Message & Clear EnterPayRateTextBox
                if (EmployeePayRateEnter >= 50)
                {

                    MessageBox.Show("Please Enter A Rate Below $50");
                    EnterPayrateTextbox.Text = String.Empty;

                }

                //**IF STATEMENT**\\ If The Hours Worked Entered Is Greater Than or Equal To 60, Print Error Message & Clear EnterHoursWorkedTextbox
                if (EmployeeHoursWorkedEnter >= 60)
                {

                    MessageBox.Show("Please Contact Your Manager If You Have Worked Over 60 Hours Or More");
                    EnterHoursWorkedTextbox.Text = String.Empty;

                }



                //(Code Block - 2.2)\\

                //**IF STATEMENT**\\ If The Hours Worked Entered Is Less Than or Equal To 40, Run Regular Total Pay Calculation Then Print Total To TotalPayTextBox
                if (EmployeeHoursWorkedEnter <= 40)

                {

                    double RegualrHoursTotalPay = EmployeeHoursWorkedEnter * EmployeePayRateEnter;

                    String DisplayRegualrTotalPay = Convert.ToString(RegualrHoursTotalPay);

                    TotalPayTextBox.Text = String.Format("$" + DisplayRegualrTotalPay + " (Regular Pay Rate)");
                    
                }

                //**ELSE**\\ Else Run Time And A Half Calculation Then Print To  TotalPayTextBox
                else
                {
                    
                   double TimeAndAHalfTRate =  1.5 * EmployeePayRateEnter;

                   double TimeAndAHalfTotalPay = TimeAndAHalfTRate * EmployeeHoursWorkedEnter;

                   String DisplayTimeAndAHalfTotalPay = Convert.ToString(TimeAndAHalfTotalPay);

                   TotalPayTextBox.Text = String.Format("$" + DisplayTimeAndAHalfTotalPay + " (Time & Half Pay Rate)");

                   // OpenFileDialog openFileDialog1 = new OpenFileDialog();

                   // openFileDialog1.ShowDialog();



                }

            }

            catch (System.FormatException)
            {

                MessageBox.Show("You Did Not Enter A Number Value, Please Try Again");

            }

            //**PAYROLL CALCULATION SECTION END**\\

        }

        private void PayRollExportSectionButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PayRollCalculationClearButton_Click(object sender, EventArgs e)
        {
            EnterFullNameTextBox.Text = String.Empty;
            EnterEmployeeIDTextBox.Text = String.Empty;
            EnterPayrateTextbox.Text = String.Empty;
            EnterHoursWorkedTextbox.Text = String.Empty;
            TotalPayTextBox.Text = String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();


            openFileDialog1.InitialDirectory = @"C:\";

        }
    }
}
