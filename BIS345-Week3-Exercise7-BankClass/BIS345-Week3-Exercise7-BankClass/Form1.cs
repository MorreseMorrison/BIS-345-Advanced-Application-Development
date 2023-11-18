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
//Date Completed: 11/17/2023 6:08
//Professor: Dr. Nathan Kilgore
//University: Peirce College
//Class: BIS 345 - Advanced Application Development
//Assignment: Week 3 Assignment #7, Page 784
//Program Description: This Program Demonstrates Inheritance Of Classess. There Are Three Classess. One Parent Class & Two Child Classess
//The Parent Class Can Not Be Instantiated As It Is Abstract. However It Has Several Properties That Are Inherited Respectively To
//The SavingsAccount Class & The CheckingAccountClass. When The Program Is Executed, The User's Bank Account Information is Displayed
//On The Form. This Is Executed By Objects Being Created From Both Of The Child Classess, Having Values Addedd To That Object, Then
//Having Those Same Objects Print To The Various Text Label Boxes.

namespace BIS345_Week3_Exercise7_BankClass
{
    public partial class Form1 : Form
    {



        //Classess 3 Main Classess. One Parent, & Two Child Classess.

        //(Class 1 Of 3) This Is The Parent Class Named "Bank Account". It Contains Several Properties That Are Associated
        //With Bank Accounts. This Parent Class Is Abstract, Meaning It Can Not Be Instantiated. However, The Child Classess
        //Associated With This Parent Class Can Be Instantiated.
         abstract class BankAccount {

            public string First_Name { get; set;}

            public string Middle_Name { get; set;}

            public string Last_Name { get; set;}

            public string Home_Address { get; set;}

            public string Phone_Number { get; set; }

            public string Account_Number { get; set;}

            public string Social_Security_Number { get; set;}

            public string Debit_Card_Number { get; set;}

            public string Total_Balance { get; set; }

            public string Saving_Account_Interest_Rate { get; set;}

            public string Account_Minimum { get; set; }

            public string ATM_Bank_Card_Number { get; set; }

        }

        //(Class 2 Of 3) This Is A Child Class Of The Bank Account Class. The Properties Used Within This Class Are Inherited From
        //The BankAccount Parent Class. The Appropriate Properties Are Utilized Respective To Checking Accounts.

        class CheckingAccount : BankAccount{

        }

        //(Class 3 Of 3) This Is A Child Class Of The Bank Account Class. The Properties Used Within This Class Are Inherited From
        //The BankAccount Parent Class. The Appropriate Properties Are Utilized Respective To Savings Accounts.

        class SavingsAccount : BankAccount{

        }

       //**END OF ALL THREE CLASSESS**//


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //**MAIN LOGIC**//


            //START//
            //(Code Block 1) - OBJECT CREATION CheckingAccount() Class
            CheckingAccount Morrese_David_Morrison_Checking_Account = new CheckingAccount(); 

            //(Code Block 1.1) Adding Values To Created Object
            Morrese_David_Morrison_Checking_Account.First_Name = "Morrese";
            Morrese_David_Morrison_Checking_Account.Middle_Name = "David";
            Morrese_David_Morrison_Checking_Account.Last_Name = "Morrison";
            Morrese_David_Morrison_Checking_Account.Home_Address = "123 Easy Street PA";
            Morrese_David_Morrison_Checking_Account.Phone_Number = "610-352-3367";
            Morrese_David_Morrison_Checking_Account.Total_Balance = "$26,549.00";
            Morrese_David_Morrison_Checking_Account.Account_Number = "68037674";
            Morrese_David_Morrison_Checking_Account.Social_Security_Number = "124541243";
            Morrese_David_Morrison_Checking_Account.Debit_Card_Number = "5617572781182960";
            Morrese_David_Morrison_Checking_Account.Account_Minimum = "$500.00";

            //(Code Block 1.2) - Printing Object Values To Text Labels 
            FirstNameTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.First_Name.ToString();
            MiddleNameTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Middle_Name.ToString();
            LastNameTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Last_Name.ToString();
            HomeAddressTextBocxChecking.Text = Morrese_David_Morrison_Checking_Account.Home_Address.ToString();
            PhoneNumberTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Phone_Number.ToString();
            TotalBalanceTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Total_Balance.ToString();
            AccountNumberTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Account_Number.ToString();
            SocialSecurityNumberTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Social_Security_Number.ToString();
            DebitCardNumberTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Debit_Card_Number.ToString();
            AccountMinimumTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Account_Minimum.ToString();
            //End Code Block 1//
            //STOP//


            //START//
            //(Code Block 2) - OBJECT CREATION SavingsAccount() Class
            SavingsAccount Morrese_David_Morrison_Savings_Account = new SavingsAccount();

            //(Code Block 2.1) Adding Values To Created Object
            Morrese_David_Morrison_Savings_Account.First_Name = "Morrese";
            Morrese_David_Morrison_Savings_Account.Middle_Name = "David";
            Morrese_David_Morrison_Savings_Account.Last_Name = "Morrison";
            Morrese_David_Morrison_Savings_Account.Home_Address = "123 Easy Street PA";
            Morrese_David_Morrison_Savings_Account.Phone_Number = "610-352-3367";
            Morrese_David_Morrison_Savings_Account.Total_Balance = "$47,999.00";
            Morrese_David_Morrison_Savings_Account.Account_Number = "47737674";
            Morrese_David_Morrison_Savings_Account.Social_Security_Number = "124541243";
            Morrese_David_Morrison_Savings_Account.ATM_Bank_Card_Number = "3219891251998870";
            Morrese_David_Morrison_Checking_Account.Saving_Account_Interest_Rate = "2.7 %";

            //(Code Block 2.2) - Printing Object Values To Text Labels 
            FirstNameTextBoxSavings.Text = Morrese_David_Morrison_Checking_Account.First_Name.ToString();
            MiddleNameTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Middle_Name.ToString();
            LastNameTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Last_Name.ToString();
            HomeAddressTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Home_Address.ToString();
            PhoneNumberTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Phone_Number.ToString();
            TotalBalanceTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Total_Balance.ToString();
            AccountNumberTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Account_Number.ToString();
            SocialSecurityNumberTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.Social_Security_Number.ToString();
            ATMCardNumberTextBoxSavings.Text = Morrese_David_Morrison_Savings_Account.ATM_Bank_Card_Number.ToString();
            InterestRateTextBoxSavings.Text = Morrese_David_Morrison_Checking_Account.Saving_Account_Interest_Rate.ToString();
            //End Code Block 2//
            //STOP


            //**END MAIN LOGIC**//


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
