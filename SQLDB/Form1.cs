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
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string fname = txtInput.Text;
            string sname = txtinput2.Text;
            int age = int.Parse(txtinput3.Text);

            DBConn dBConn = new DBConn();

            dBConn.writeToDB(fname, sname, age);
        }




        private void WritetoDB(string input)
        {

        }

        private string ReadDB()
        {
            
            return "yeet";
        }






        //Select all from DB
        private void button2_Click(object sender, EventArgs e)
        {

            List<Model> models = new List<Model>();
            DBConn dBConn = new DBConn();

            models = dBConn.selectALL();

            foreach (Model model in models)
            {
                textBox1.AppendText(
                    model.fName + " " +
                    model.sName + " " +
                    model.age.ToString() +
                    System.Environment.NewLine
                    );
            }


            
        }


        //Read from DB
       
        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtInput.Text;
            string sname = txtinput2.Text;

            List<string> names = new List<string>();
            DBConn dbConn = new DBConn();

            names = dbConn.SelectWhere(fname, sname);

            foreach(string name in names)
            {
                textBox1.AppendText(name + System.Environment.NewLine);
            }
           
        }
    }
}
