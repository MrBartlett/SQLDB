using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB
{
    internal class BLogic
    {


        public bool DeleteWhere(string name)
        {
            DBConn dBConn = new DBConn();
            bool rturn = dBConn.DeleteWhere(name);
            return rturn;
        }


        public bool DeleteAll()
        {
            DBConn dbConn = new DBConn();
            bool rturn = dbConn.DeleteAll();

            return rturn;
        }

        // Select where Business layer m8
        // we might do some hellasick processing here to make the logik go brrrrr
        // #relatable #neverevercommentlikethis #trash
        public List<string> Selectwhr(string fname, string sname)
        {

            // we could do some data validation here to protec our DB
            // from SQL injection, we may also Do LogiK on our data
            // WHy? WELL for example a DB search probably shouldnt be case sensitive so
            // So we might convert all entries to lowercase (or upper, idc)

            List<string> rturn = new List<string>();

            fname = fname.ToLower(); // now fname is lowercase

            sname = sname.ToLower(); // now sname is lowercase bruh so fancy dab

            // Might we need to do anything to our the return from our db?
            DBConn dbConn = new DBConn();
            rturn = dbConn.SelectWhere(fname, sname);

            //Now we need to reformat our strings to look like we understand grammer



            return rturn;
        }

        //Writing to a DB
        public bool WritetoDBBL(Model User)
        {
            DBConn dBConn = new DBConn();

            // converts strings to lower case
            User.fName = User.fName.ToLower();
            User.sName = User.sName.ToLower();

            return dBConn.writeToDB(User);

        }

        // Im not doing processing here because im not creative enough
        // to think of anything good to demo here
        public List<Model> SelectAllBL()
        {
            DBConn dbConn = new DBConn();

            List<Model> rturn = dbConn.selectALL();

            return rturn;
        }
    
    }
}
