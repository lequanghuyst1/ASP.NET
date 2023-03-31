using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Course_Student
    {
        public Course_Student(Course cs, List<Student> lst)
        {
            this.cs = cs;
            this.lst = lst;
        }

        public Course cs { get; set; }
        public List<Student> lst { get; set; }
    }
}