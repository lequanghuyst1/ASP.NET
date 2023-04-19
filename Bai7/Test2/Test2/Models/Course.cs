using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Course
    {
        

        public string CID { get; set; }
        public string CName { get; set; }
        public Course()
        {

        }
        public Course(string cID, string cName)
        {
            CID = cID;
            CName = cName;
        }
    }
}