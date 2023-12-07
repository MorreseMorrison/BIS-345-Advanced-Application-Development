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


        //(Part - 1 - PAYROLL CALCULATION SECTION - START)
        private void PayRollCalculationSectionButton_Click(object sender, EventArgs e)
        {


            //VARIABLES
            String EmployeeFullNameEnter;
            String EmployeeIDEnter;
            double EmployeePayRateEnter;
            double EmployeeHoursWorkedEnter;



           //**PAYROLL CALCULATION SECTION START**\\

            try
            {

                //(CODE BLOCK - 1 - START) = User Enter Values Via Text Labels
                EmployeeFullNameEnter = EnterFullNameTextBox.Text;
                EmployeeIDEnter = EnterEmployeeIDTextBox.Text;
                EmployeePayRateEnter = double.Parse(EnterPayrateTextbox.Text);
                EmployeeHoursWorkedEnter = double.Parse(EnterHoursWorkedTextbox.Text);


                //(Code Block - 2 - START) = If & Else Statements Then  Payroll Calculation
                //(Code Block - 2.1)\\
                //**IF STATEMENT**\\ If The Rate Entered Is Greater Than or Equal To 50, Print Error Message & Clear EnterPayRateTextBox
                if (EmployeePayRateEnter >= 50)
                {

                    MessageBox.Show("Please Enter A Rate Below $50");
                    EnterPayrateTextbox.Text = String.Empty;

                }
                //(Code Block - 2.1)\\

                //(Code Block - 2.2)\\
                //**IF STATEMENT**\\ If The Hours Worked Entered Is Greater Than or Equal To 60, Print Error Message & Clear EnterHoursWorkedTextbox
                if (EmployeeHoursWorkedEnter >= 60)
                {

                    MessageBox.Show("Please Contact Your Manager If You Have Worked Over 60 Hours Or More");
                    EnterHoursWorkedTextbox.Text = String.Empty;

                }
                //(Code Block - 2.2)\\

                //(Code Block - 2.3)\\
                //**IF STATEMENT**\\ If The Hours Worked Entered Is Less Than or Equal To 40, Run Regular Total Pay Calculation Then Print Total To TotalPayTextBox
                if (EmployeeHoursWorkedEnter <= 40)

                {
                    //PART 1//
                    //**START Regualr Pay Calculation Logic**\\
                    double RegualrHoursTotalPay = EmployeeHoursWorkedEnter * EmployeePayRateEnter;

                    String DisplayRegualrTotalPay = Convert.ToString(RegualrHoursTotalPay);

                    TotalPayTextBox.Text = String.Format("$" + DisplayRegualrTotalPay);

                    PayTypeTextBox.Text = ("Regular Pay Rate");

                    //**END Time & Half Calculation Logic**\\
                    //PART 1//



                    //PART 2//
                    //**START Export File Logic** = Sends The Text File To The Users Public Documents Utilizes The File.WriteAllText Method**\\
                    File.WriteAllText(@"C:\Users\Public\Documents\PeirceCollegePayrollExportTimeHalfPay.txt", "PEIRCE COLLEGE HOURLY PAYROLL EXPORT" + "\n" +
                     "\n" + "Full Name: " + EmployeeFullNameEnter + "\n" + "Total Gross Pay: " + "$" + DisplayRegualrTotalPay + "\n" + "Employee ID: " +
                      EmployeeIDEnter + "\n" + "Payrate: " + "$" + EmployeePayRateEnter + "\n" + "Hours Worked: " + EmployeeHoursWorkedEnter
                      + "\n" + "Pay Type: Regular Pay Rate");

                    //Message Box Telling The User To Check Their Public Documents Folder For The Export File

                    MessageBox.Show("Please Check Your Public Documents Folder For Your Export" + "\n" + "Example: C:/Users/Public/Documents/PeirceCollegePayrollExport.txt");

                    //**END Export File Logic**\\
                    //PART 2//

                }
                //(Code Block - 2.3)\\

                //(Code Block - 2.4)\\      
                //**ELSE**\\ Else Run Time And A Half Calculation Then Print To TotalPayTextBox
                else
                {

                    //PART 1//
                   //**START Time & Half Calculation Logic**\\
                    
                   double TimeAndAHalfTRate =  1.5 * EmployeePayRateEnter;

                   double TimeAndAHalfTotalPay = TimeAndAHalfTRate * EmployeeHoursWorkedEnter;

                   String DisplayTimeAndAHalfTotalPay = Convert.ToString(TimeAndAHalfTotalPay);

                   TotalPayTextBox.Text = String.Format("$" + DisplayTimeAndAHalfTotalPay);

                   PayTypeTextBox.Text = ("Time & Half Pay Rate");

                   //**END Time & Half Calculation Logic**\\
                   //PART 1//


                  
   
                   //PART 2//
                   //**START Export File Logic** = Sends The Text File To The Users Public Documents Utilizes The File.WriteAllText Method**\\

                    File.WriteAllText(@"C:\Users\Public\Documents\PeirceCollegePayrollExportTimeHalfPay.txt", "**PEIRCE COLLEGE HOURLY PAYROLL EXPORT**" + "\n" +
                       "\n" + " Full Name: " + EmployeeFullNameEnter + "\n" + " Total Gross Pay: " + "$" + DisplayTimeAndAHalfTotalPay + "\n" + " Employee ID: " +
                        EmployeeIDEnter + "\n" + " Payrate: " + "$" + EmployeePayRateEnter + "\n" + " Hours Worked: " + EmployeeHoursWorkedEnter 
                        + "\n" + " Pay Type: Time & Half Pay Rate");

                    //Message Box Telling The User To Check Their Public Documents Folder For The Export File

                    MessageBox.Show("Please Check Your Public Documents Folder For Your Export" + "\n" + "Example: C:/Users/Public/Documents/PeirceCollegePayrollExport.txt");

                   //**END Export File Logic**\\
                   //PART 2//
                }
                //(Code Block - 2.4)\\                
                //(CODE BLOCK - 2 - END) 

            }

            catch (System.FormatException)
            {

                MessageBox.Show("Please Enter Only Letters For The Full Name Field & Numbers For The Payrate, Employee ID and Hours Worked Field"); 

            }

            //**PAYROLL CALCULATION SECTION END**\\

        }
        //(Part - 1 - PAYROLL CALCULATION SECTION - END)

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

        //(Part - 2 - PAYROLL IMPORT SECTION - START)
        private void button4_Click(object sender, EventArgs e)
        {

            //When Clicking The Import Button, The Open File Dialog Will Appear
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //When The File Dialog Appears, Only TXT Files Will Be Selectable
            openFileDialog1.Filter = "TXT files|*.txt";

            //
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportFilePathTextBox.Text = openFileDialog1.FileName;

                string file = openFileDialog1.FileName;

                string str = File.ReadAllText(file);

                PayrollImportSectionTextBox.Text = (str);
                
            }


        }
        //(Part - 2 - PAYROLL IMPORT SECTION - END)


        //**Payroll Import Section Clear Button**\\
        private void button5_Click(object sender, EventArgs e)
        {
            PayrollImportSectionTextBox.Text = String.Empty;
            ImportFilePathTextBox.Text = String.Empty;

        }

        private void PayTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
