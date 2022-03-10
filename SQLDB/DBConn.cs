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



        private void writeToDB(string name)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Satellite\source\repos\SQLDB\SQLDB\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();
            int i = cmd.ExecuteNonQuery();
        }




    }

  
}
