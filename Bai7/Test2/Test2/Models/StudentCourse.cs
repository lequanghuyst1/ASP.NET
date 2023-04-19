using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class StudentCourse
    {
        public Course cs { get; set; }
        public List<Student> students { get; set; }
        public StudentCourse()
        {
            cs = new Course();
            students = new List<Student>();
        }
    }
    
}

