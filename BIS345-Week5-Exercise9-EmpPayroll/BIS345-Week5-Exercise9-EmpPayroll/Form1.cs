using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //(Code Block - 1)

            try
            {

                EmployeeFullNameEnter = EnterFullNameTextBox.Text;
                EmployeeIDEnter = EnterEmployeeIDTextBox.Text;
                EmployeePayRateEnter = double.Parse(EnterPayrateTextbox.Text);
                EmployeeHoursWorkedEnter = double.Parse(EnterHoursWorkedTextbox.Text);

                if (EmployeePayRateEnter >= 50)
                {

                    MessageBox.Show("Please Enter A Rate Below $50");
                    EnterPayrateTextbox.Text = String.Empty;

                }

                if (EmployeeHoursWorkedEnter >= 60)
                {

                    MessageBox.Show("Please Contact Your Manager If You Have Worked Over 60 Hours Or More");
                    EnterHoursWorkedTextbox.Text = String.Empty;

                }
                //System.FormatException: 

            }

            catch (System.FormatException)
            {

                MessageBox.Show("You Did Not Enter A Number Value, Please Try Again");

            }

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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
