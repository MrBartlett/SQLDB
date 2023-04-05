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

        // below is a typical interface level method, no real processing is done
        // just providing a layer of protection for lower layers of the application
        private void btnInput_Click(object sender, EventArgs e)
        {
            string fname;
            string sname;
            int age;
            bool flag;

            // checks if any of the textboxes are empty (protects our logic from nulls)
            if (String.IsNullOrEmpty(txtInput.Text) || String.IsNullOrEmpty(txtinput2.Text) || String.IsNullOrEmpty(txtinput3.Text))
            {
                flag = false;
            }
            else
            {
                fname = txtInput.Text;
                sname = txtinput2.Text;
                age = int.Parse(txtinput3.Text);

                // calls appropriate BL method to kick off the process of 
                // writing to a db, you'll note that the method returns a bool
                // this bool is a flag and indicates the success of the write
                BLogic logik = new BLogic();
                flag = logik.WritetoDBBL(fname, sname, age);

            }

            // you know what a flag is right?
            // uses the flag to provide output to the user
            if(flag == true)
            {              
                    pbSuccess.Visible = true;
                pbFail.Visible = false;
                txtOutput.Text = "Successfully written to DB";
            }
            else
            {
                    pbSuccess.Visible = false;
                    pbFail.Visible = true ;
                txtOutput.Text = "Nothing written to DB";
                

            }            
        }

        //Select all from DB
        private void button2_Click(object sender, EventArgs e)
        {

            List<Model> models = new List<Model>();
            BLogic logik = new BLogic();

            models = logik.SelectAllBL();

            foreach (Model model in models)
            {
                txtOutput.AppendText(
                    model.fName + " " +
                    model.sName + " " +
                    model.age.ToString() +
                    System.Environment.NewLine
                    );
            }


            
        }


        //Read from DB where fname and sname = x
       private void btnSearch_Click(object sender, EventArgs e)
        {
            string fname = txbFnameS.Text;
            string sname = txbSNameS.Text;

            List<string> names = new List<string>();

            BLogic bl = new BLogic();

            names = bl.Selectwhr(fname, sname);

            foreach (string name in names)
            {
                txtOutput.AppendText(name + System.Environment.NewLine);
            }
        }


        //select all
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            BLogic logik = new BLogic();
            List<Model> models = logik.SelectAllBL();

            // VS generated this code for me and I didnt have the heart to change it to
            // A foreach, but it works anyway so win
            // You could also use a foreach here
            foreach(Model model in models)
            { 
                txtOutput.AppendText(model.fName + " " 
                    + model.sName + " " 
                    + model.age + System.Environment.NewLine);
            }
        }

        private void btnSearchJoined_Click(object sender, EventArgs e)
        {
            DBConn conn = new DBConn();
            string data = conn.SelectJoined(txbFnameS.Text, txbSNameS.Text);
            txtOutput.Text = data;
        }
    }
}
