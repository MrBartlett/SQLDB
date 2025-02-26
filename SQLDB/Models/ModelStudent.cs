using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB.Models
{
    public class ModelStudent
    {


        public int Id { get; set; }
        public string fname { get; set; }
        public string sname { get; set; }
        public int age { get; set; }

        public bool enrollmentStatus { get; set; }

        public int classID { get; set; }  


        public ModelStudent() 
        {
        
        }


    }
}
