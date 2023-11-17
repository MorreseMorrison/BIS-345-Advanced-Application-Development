using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS345_Week3_Exercise7_BankClass
{
    public partial class Form1 : Form
    {


        
         abstract class BankAccount {

            
        
            // double Total_Balance;
            // double Savings_Account_Interest_Rate;
            // double Account_Minimum;



            public string First_Name { get; set;}

            public string Middle_Name { get; set;}

            public string Last_Name { get; set;}

            public string Home_Address { get; set;}

            public string Account_Name { get; set;}

            public string Social_Security_Number { get; set;}

            public string Debit_Card_Number { get; set;}

            public string Total_Balance { get; set; }

            public string Saving_Account_Interest_Rate { get; set;}

            public string Account_Minimum { get; set; }

            public string ATM_Bank_Card_Number { get; set; }




            // public void Test()
            // {


            // }



        }

        class CheckingAccount : BankAccount{





        }

        class SavingsAccount : BankAccount{



        }

       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SavingsAccount Morrese_David_Morrison_Savings_Account = new SavingsAccount();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckingAccount Morrese_David_Morrison_Checking_Account = new CheckingAccount {First_Name = "Morrese"};
            Morrese_David_Morrison_Checking_Account.Middle_Name = "David";

            FirstNameTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.First_Name.ToString();
            MiddleNameTextBoxChecking.Text = Morrese_David_Morrison_Checking_Account.Middle_Name.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
