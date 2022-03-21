using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB
{
    public class Model
    {

        public string fName { get; set; }

        public string sName { get; set; }
        public int age { get; set; }


        public Model()
        {

        }

        public Model(string fName, int age, string sName)
        {
            this.fName = fName;
            this.sName = sName;
            this.age = age;
        }
    }
}
