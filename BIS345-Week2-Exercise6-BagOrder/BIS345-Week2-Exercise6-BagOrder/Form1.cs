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
//Program: Bag Ordering Form
//Class: BIS 345 - Advanced Application Development
//Professor: Dr. Nathan Kilgore
//Completion Time: 11/10/2023 11:20AM
//University: Peirce College Philadelphia
//Description: This Program Allows A User To Enter Their Name, Select A Bag, Select A Quantity
//Then Click The Order Button To Order Their Bag. If Statements Have Been Invoked To Prevent
//A User From Not Selecting A Bag, Quanity Or From Entering Their Name When Placing Their Order


namespace BIS345_Week2_Exercise6_BagOrder
{
    public partial class QuantityComboBox1 : Form
    {
        public QuantityComboBox1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void TitleLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void OrderButton4_Click(object sender, EventArgs e)
        {

            //**MAIN LOGIC\\


            //(Code Block - 1) = The User Will Enter Their Full Name Into The Text Box, It Will Then Feed That To string Variable "FullName"
             string FullName = EmployeeNameTextBoxLabel3.Text;


            //(Code Block - 2) = The User Will Select The Bag That They Would Like, This Will Then Feed string Variable "UserSelectionBag"
            string UserSelectionBag = BagListBox1.GetItemText(BagListBox1.SelectedItem);

            //(Code Block - 3) = The User Will Select The Quantity That They Would Like, This Will Then Feed string Variable "UserSelectionBagQuantity"
            string UserSelectionBagQuantity = SelectQuantityComboBox1.GetItemText(SelectQuantityComboBox1.SelectedItem);

            //(Code Block - 4) = If Statement That Determines If A User Enters Their Full Name, If They Select A Bag, Of If They Select A Quantity
            //If Not, They Will Receive The Appropriate Error Messages Prompting Them To Do So. If They Have, The Message Box Will Print
            if (FullName == String.Empty)
            {
                MessageBox.Show("Please Enter Your Full Name");
            }
            //Further Validation Can Be Invoked To Check For Numbers & Special Characters
            if (BagListBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Bag");
            }

            if (SelectQuantityComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Quantity");
            }
  
                 else
                         {
                            MessageBox.Show("ORDER CONFIRMATION" + " \n" + "Full Name: " + FullName + " \n" + "Bag Orderd: " 
                             
                             + UserSelectionBag + " \n" + "Quantity: " + UserSelectionBagQuantity.ToString());

                                }
            //CODE BLOCK - 4 **END\\
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EmployeeNameTextBoxLabel3_TextChanged(object sender, EventArgs e)
        {
            //**ATTENTION** = Maximum Set Characters Is 25 Within Properties
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            //**EXTRAS (1)** - All Three Of These Methods Will Clear Any Entries Within The Text Box & Any Selection In The ComboBox & ListBox\\
            BagListBox1.ClearSelected();
            SelectQuantityComboBox1.SelectedItem = null;
            EmployeeNameTextBoxLabel3.Clear();
            //END CODE Block - EXTRAS (1)\\
            
        }

    }
}
