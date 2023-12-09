using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Input Out Put Library This Is Required For Import Export Methods
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Morrese Morrison
//Date Completed: 12/9/2023 1:47PM
//University: Peirce College
//Course: BIS 345 Advanced Application Development
//Professor: Dr. Nathan Kilgore
//Program Description: This Program Calculates The Gross Pay For An Employee In An Export File As Well As Give The User The Ability
//To Import That Same File. The User May Enter Their Full Name, Employee ID, Pay Rate, & Hours Worked. 
//Once All Of That Is Entered, They Will Click The "Calculate & Import" Button. This Button Will Calculate
//All Of The Information Entered And Export The File To C:\users\public\documents. If The User Enters Worked Hours Over 40, Time & Half
//Calculation Will Be Ran, If Not, Their Regualr Rate Will Be Calculated. Under Payroll Import Section, Once The User Selects The
//Import Button, The File Dialog Will Appear Where They Will Be Able To Import Their Text File. Once They Select Their Payroll File
//The File Will Be Imported And Displayed In A TextBox.


namespace BIS345_Week5_Exercise9_EmpPayroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //**MAIN LOGIC - 1**\\
        //(Part - 1 - PAYROLL CALCULATION SECTION - START )
        private void PayRollCalculationSectionButton_Click(object sender, EventArgs e)
        {


            //VARIABLES
            String EmployeeFullNameEnter;
            double EmployeeIDEnter;
            double EmployeePayRateEnter;
            double EmployeeHoursWorkedEnter;



           //**PAYROLL CALCULATION SECTION START**\\

            try
            {

                //(CODE BLOCK - 1 - START) = User Enter Values Via Text Labels
                EmployeeFullNameEnter = EnterFullNameTextBox.Text;
                EmployeeIDEnter = double.Parse(EnterEmployeeIDTextBox.Text);
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
                //**IF STATEMENT**\\ If The EmployeeID That Is Entered Has All Zeros, Print Error Message & Clear EmployeeIDEnterTextBox
                if (EmployeeIDEnter == 0 || EmployeeIDEnter == 00 || EmployeeIDEnter == 000 || EmployeeIDEnter == 0000)
                { 

                    MessageBox.Show("A User ID May Not Have All Zeros, Please Enter Your Correct User ID");
                    EnterEmployeeIDTextBox.Text = String.Empty;

                    //Initially Before The Restart Method, The Program Would Still Run The Export, This Was Added To Prevent That
                    Application.Restart();

                }
                //(Code Block - 2.3)\\


                //(Code Block - 2.4)\\
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
                //(Code Block - 2.4)\\


                //(Code Block - 2.5)\\      
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
                //(Code Block - 2.5)\\ 


                
                //(CODE BLOCK - 2 - END) 

            }


            //Catch Statement For Any Format Exceptions, If This Exception Materializes Clear All Text Boxes Under The Payroll Calculation Section
            catch (System.FormatException)
            {

                MessageBox.Show("Please Enter Only Letters For The Full Name Field & Numbers For The Payrate, Employee ID and Hours Worked Field");
                EnterFullNameTextBox.Text = String.Empty;
                EnterEmployeeIDTextBox.Text = String.Empty;
                EnterPayrateTextbox.Text = String.Empty;
                EnterHoursWorkedTextbox.Text = String.Empty;
                TotalPayTextBox.Text = String.Empty;
            }

            //**PAYROLL CALCULATION SECTION END**\\

        }
        //(Part - 1 - PAYROLL CALCULATION SECTION - END)
        //**MAIN LOGIC - 1**\\

        private void PayRollExportSectionButton_Click(object sender, EventArgs e)
        {
            
        }

        //(Part - 1 - PAYROLL CALCULATION SECTION CLEAR BUTTON)
        private void PayRollCalculationClearButton_Click(object sender, EventArgs e)
        {
            EnterFullNameTextBox.Text = String.Empty;
            EnterEmployeeIDTextBox.Text = String.Empty;
            EnterPayrateTextbox.Text = String.Empty;
            EnterHoursWorkedTextbox.Text = String.Empty;
            TotalPayTextBox.Text = String.Empty;

        }
        //(Part - 1 - PAYROLL CALCULATION SECTION CLEAR BUTTON)

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //**MAIN LOGIC - 2**\\
        //(Part - 2 - PAYROLL IMPORT SECTION - START)
        private void button4_Click(object sender, EventArgs e)
        {

            //(Code Block - 2.1\\ Utilizing The Open File Dialog Method When The Import Button Is Clicked
            //When Clicking The Import Button, The Open File Dialog Will Appear
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            //When The File Dialog Appears, Only TXT Files Will Be Selectable
            OpenFileDialog1.Filter = "TXT files|*.txt";
            


            //(Code Block 2.2)\\
            //If Statement Utilizing ShowDialog() When Selecting The Text File That You Would Like To Import
            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //Path Of The Selected File Is Listed In The ImportFilePathTextBox
                ImportFilePathTextBox.Text = OpenFileDialog1.FileName;

                //Contents Of The File Is Assigned To ImportFile
                string ImportFile = OpenFileDialog1.FileName;

                //Contents From Import File Is Read Via File.ReadAllText Then Assigned To ImportFileRead
                string ImportFileRead = File.ReadAllText(ImportFile);

                //Contents From ImportFileRead Variable Is Displayed In The PayrollImportSectionTextBox Text Box
                PayrollImportSectionTextBox.Text = (ImportFileRead);

                //Message Box Prompt Confirming That You Have 
                MessageBox.Show("You Have Successfully Imported  Your Payroll File");
                
            }


        }
        //(Part - 2 - PAYROLL IMPORT SECTION - END)
        //**MAIN LOGIC - 2**\\


        //(Part - 2 - PAYROLL IMPORT SECTION CLEAR BUTTON)
        private void button5_Click(object sender, EventArgs e)
        {
            PayrollImportSectionTextBox.Text = String.Empty;
            ImportFilePathTextBox.Text = String.Empty;

        }
        //(Part - 2 - PAYROLL IMPORT SECTION CLEAR BUTTON)


        private void PayTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterFullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
