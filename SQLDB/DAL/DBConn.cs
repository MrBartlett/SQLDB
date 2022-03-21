using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace SQLDB
{
    internal class DBConn
    {
        private static string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hayde\source\repos\SQLDB\SQLDB\DAL\Database1.mdf;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(sqlConnectionString);


        public bool writeToDB(string fname, string sname, int age)
        {
            try
            {
                string addtotable = "INSERT INTO [tblenrolments] (fname, sname, age) " + "VALUES ('" + fname + "','" + sname + "','" + age + "');";


                conn.Open();

                using (SqlCommand command = new SqlCommand(addtotable, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Model> selectALL()
        {
            List<Model> list = new List<Model>();
            string searchQuery = "SELECT * FROM [tblenrolments]";

            conn.Open();

            using (SqlDataReader reader = new SqlCommand(searchQuery, conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    Model model = new Model();

                    model.fName = reader["fname"].ToString();
                    model.sName = reader["sname"].ToString();
                    model.age = int.Parse(reader["age"].ToString());

                    list.Add(model);
                }

            }
            conn.Close();
            return list;
            
        }

        public List<string> SelectWhere(string fname, string sname)
        {
            string searchQuery = "SELECT * FROM [tblenrolments] WHERE fname = '" + fname + "' AND sname = '" + sname + "'";

            List<string> list = new List<string>();

                conn.Open();

                using (SqlDataReader reader = new SqlCommand(searchQuery, conn).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader["fname"].ToString());
                    }

                }
                conn.Close();

            return list;

        }





    }


}
