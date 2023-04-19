using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class Course
    {
    

        public int CID { get; set; }
        public string CName { get; set; }
        public Course(int cID, string cName)
        {
            CID = cID;
            CName = cName;
        }
        public Course()
        {

        }
    }
}