using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string UserSelectionBagQuantity = comboBox1.GetItemText(comboBox1.SelectedItem);
            string FullName = EmployeeNameTextBoxLabel3.Text;


            string UserSelectionBag = BagListBox1.GetItemText(BagListBox1.SelectedItem);
            MessageBox.Show("Full Name: " + FullName + " \n" + "Bag Orderd: " + UserSelectionBag + " \n" + "Quantity: " + UserSelectionBagQuantity.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EmployeeNameTextBoxLabel3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            BagListBox1.ClearSelected();
            
        }
    }
}
