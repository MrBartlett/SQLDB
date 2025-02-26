using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;
using System.Reflection;

namespace SQLDB
{
    internal class DBConn
    {

        private static string sqlConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
            "\\DAL\\Database1.mdf" + ";Integrated Security=True";

        private SqlConnection conn = new SqlConnection(sqlConnectionString);


        //Writing to a Database
        public bool writeToDB(Model user)
        {

            try
            {
                string addtotable = "INSERT INTO [tblenrolments] (fname, sname, age) VALUES " +
                    "('" + user.fName + "','" + user.sName + "','" + user.age + "');";

                // INSERT INTO [tblenrolments] (fname, sname, age) VALUES ('Ben','Johnson','35');

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

        public bool DeleteWhere(string name)
        {
            try
            {

                string addtotable = "DELETE FROM tblenrolments WHERE fname='" + name.ToLower() + "';";

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

        // Delete all
        public bool DeleteAll()
        {
            try
            {
                
                string addtotable = "DELETE FROM tblenrolments";

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


        // selecting all from database
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

        public bool Update(Model user)
        {
            try
            {
                string updateQuery = "UPDATE [tblenrolments] SET age = '" + user.age + "' " +
                                     "WHERE fname = '" + user.fName + "' AND sname = '" + user.sName + "';";

                conn.Open();

                using (SqlCommand command = new SqlCommand(updateQuery, conn))
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




        // Select where from database
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
