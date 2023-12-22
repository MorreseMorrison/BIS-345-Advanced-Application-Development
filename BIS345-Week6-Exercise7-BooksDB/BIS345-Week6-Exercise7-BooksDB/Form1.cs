using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//Name: Morrese Morrison
//Date: 12/12/2023 6:38PM
//Umiversity: Peirce College
//Professor: Dr. Nathan Kilgore
//Course: BIS345: Advanced Application Development
//Program Purpose: This Program Loads Course Books Along with Their Title, ISBN Number And Associated Class Number. There Is One
//Main Function, & Two Auxiliiary Functions. The Main Function Is The "Load Course Button". This Button Starts A Connection With Our
//SQL Server Database, Executes The Query Given, Then Displays The Result On A Data Grid View. The Other Two Auiliary Functions Are The
//"Test Database Connection Button" Which Tests If The Program Can Reach The Database. And The "Clear Grid Button" Which Clears The On Screen
//Data Grid After The Query Results Are Shown. Exception Handling Is Utilized If The Program Can Not Reach The Database. Since The SQL Server
//Is Local, An Exception Will Always Be Thrown Until The String Connection Is Set To A Cloud Database Solution.33
namespace BIS345_Week6_Exercise7_BooksDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //**(Component 1 - Load Course Books Button)**//
        private void button1_Click(object sender, EventArgs e)
        {

            //**MAIN LOGIC**//
            //**START**//

           

                //(Code Block 1 - START) - Establishing A Connection With The SQL Server Database
                //(Code Block 1.1) - SQL Connection String Intilization
                String SQLConnectionString;


                //(Code Block 1.2) - SQL Connection String Assigned Database Connection String Information
                SQLConnectionString = "Data Source=MORRESEMORRDED3;Initial Catalog=BIS345;Integrated Security=True;MultipleActiveResultSets=True";


                //(Code Block 1.3) - Create An Object Of Type SqlConnection Named "SQLConnectionObject", Fed SQLConnectionString As The Parameter
                SqlConnection SQLConnectionObject = new SqlConnection(SQLConnectionString);


            //#EXCEPTION 1 START//
             try
                {

                //(Code Block 1.4) - The Connection Method Is Utilized To Create Open The Connection With The SQL Server Database
                SQLConnectionObject.Open();
                //(Code Block 1 - END)//

                            }
            

            catch (System.Data.SqlClient.SqlException)
                 {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

                            }
            //#EXCEPTION 1 END//



            //**(Code Block 2 - START)**// - Executing The Desired Query & Displaying The Result Onto A Data Grid View
            //(Code Block 2.1). Inner Join Query Between Three Tables "BookTable", "CourseBookTable", "PeirceCollegeCourseCatalogTable
            //This Query Should Select All Books, Their Course Number, Title, ISBN And Course Name, Only Three Results Should Show
            string Sql_Query_1 = "SELECT  CourseBookTable.Course_Number AS 'Course Number' , PeirceCollegeCourseCatalogTable.Course_Name AS 'Course Name', BookTable.Title AS 'Text Book Title' , BookTable.ISBN AS 'Text Book ISBN-10' " +
                " FROM ((BookTable " +
                "INNER JOIN CourseBookTable ON BookTable.ISBN = CourseBookTable.ISBN)" +
                "INNER JOIN PeirceCollegeCourseCatalogTable ON CourseBookTable.Course_Number = PeirceCollegeCourseCatalogTable.Course_Number); ";


            //(Code Block 2.2) - Created Object Of Type SqlCommnd Named "DataBaseCommand", With The Parameters Sql_Query_1 & Executing Against Our SQLConnectionObject Variable
            SqlCommand DataBaseCommand = new SqlCommand(Sql_Query_1, SQLConnectionObject);

            
            //(Code Block 2.3) - Created Variable Adapter Of Type SqlDataAdapter, This Serves As A Bridge To Our SQL Server Database
            SqlDataAdapter Adapter;


            // Created Variable DataTable Of Type DataTable, This Serves As A Viewer For Our Query
            DataTable DataTable;


            //(Code Block 2.4) - Created New Object Of SqlDataAdapter, With Our Query & Our SQLConnectionObject As Parameters
            Adapter = new SqlDataAdapter(Sql_Query_1, SQLConnectionObject);


            // Created New Object Of Type DataTable
            DataTable = new DataTable();




            //#EXCEPTION 2 START//
            try
            {

                //(Code Block 2.5) - Utilized Fill To Execute Our Query Against Our DataBase Into Our DataTable Variable
                Adapter.Fill(DataTable);

                                    }

           catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

                                    }
            //#EXCEPTION 2 END//





            //Filled Our DataGridView With The Results From Our Query Filled Into DataTable
            DataGridView1.DataSource = DataTable;


            //(Code Block 2.6) - Disposal Of Our DataBase Command Object As Well As Closing The Connection To Our SQL Server
            DataBaseCommand.Dispose();
            SQLConnectionObject.Close();


            //**(Code Block 2 - END)**//
            //**MAIN LOGIC END**//
            

        }
        //**(Component 1 - Load Course Books Button)**//

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //**(Component 2 - Testing The Database Connection)**//
        private void button3_Click(object sender, EventArgs e)
        {

            //(Code Block 1 - START) - Establishing A Connection With The SQL Server Database
            //(Code Block 1.1) - SQL Connection String Intilization
            String SQLConnectionString;

            //(Code Block 1.2) - SQL Connection String Assigned Database Connection String Information
            SQLConnectionString = "Data Source=MORRESEMORRDED3;Initial Catalog=BIS345;Integrated Security=True;MultipleActiveResultSets=True";

            //(Code Block 1.3) - Create An Object Of Type SqlConnection Named "SQLConnectionObject", Fed SQLConnectionString As The Parameter
            SqlConnection SQLConnectionObject = new SqlConnection(SQLConnectionString);



            //#EXCEPTION 1 START//

            try
            {
                //(Code Block 1.4) - The Connection Method Is Utilized To Create Open The Connection With The SQL Server Database
                SQLConnectionObject.Open();
                MessageBox.Show("Database Connection Test Is Successful!");
                //(Code Block 1 - END)//
            }


            catch (System.Data.SqlClient.SqlException)
            {

                MessageBox.Show("Error With Connecting To The Database, Please Contact Your System Administrator Before Starting The Application Again");
                System.Windows.Forms.Application.Exit();

            }

            //#EXCEPTION 1 END//



            SQLConnectionObject.Close();

        }
        //**(Component 2 - Testing The Database Connection)**//

        //**(Component 3 - Clearing The Data Grid)**//
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = null;

        }
        //**(Component 3 - Clearing The Data Grid)**//
    }
}
