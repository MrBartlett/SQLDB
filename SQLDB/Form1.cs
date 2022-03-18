using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//you need dis
using System.Data.SqlClient;


namespace SQLDB
{
    public partial class Form1 : Form
    {
        private static string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hayde\source\repos\SQLDB\SQLDB\Database1.mdf;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(sqlConnectionString);
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string fname = txtInput.Text;
            string sname = txtinput2.Text;
            int age = int.Parse(txtinput3.Text);


            string addtotable = "INSERT INTO [enrolments] (fname, sname, age) " +
                "VALUES ('" + fname + "','" + sname + "','" + age + "');";


            conn.Open();

            using (SqlCommand command = new SqlCommand(addtotable, conn))
            { 
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void WritetoDB(string input)
        {

        }

        private string ReadDB()
        {
            
            return "yeet";
        }






        //Select all from Textbox
        private void button2_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM [enrolments]";

            conn.Open();

            using (SqlDataReader reader = new SqlCommand(searchQuery, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox1.AppendText(reader["fname"].ToString() + " "
                        + reader["sname"].ToString() + " "
                        + int.Parse(reader["age"].ToString()) + " "
                        + reader["ID"].ToString()
                        + System.Environment.NewLine);
                }

            }
            conn.Close();

            
        }


        //Read from DB
       
        private void button1_Click(object sender, EventArgs e)
        {
            string yeet = "bob";
            string yoot = "smith";

            string searchQuery = "SELECT * FROM [enrolments] WHERE fname = '" + yeet + "' AND sname = '" + yoot + "'";

            conn.Open();

            using (SqlDataReader reader = new SqlCommand(searchQuery, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox1.AppendText(reader["fname"].ToString() + System.Environment.NewLine);
                }

            }
            conn.Close();

        }
    }
}
