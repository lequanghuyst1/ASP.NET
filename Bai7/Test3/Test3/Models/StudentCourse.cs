using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    public class StudentCourse
    {
        public Course course { get; set; }
        public List<Student> Students;

        public StudentCourse()
        {
            course = new Course();
            Students = new List<Student>();
        }
    }
}