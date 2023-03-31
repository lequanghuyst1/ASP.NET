using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Course
    {
        public Course(string courseID, string courseName)
        {
            CourseID = courseID;
            CourseName = courseName;
        }

        public String CourseID { get; set; }
        public String CourseName { get; set; }
    }
}