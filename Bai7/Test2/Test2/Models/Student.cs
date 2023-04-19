using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Student
    {
        

        public string SID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public Student()
        {

        }
        public Student(string sID, string name, string age, string address)
                {
                    SID = sID;
                    Name = name;
                    Age = age;
                    Address = address;
                }
    }
}