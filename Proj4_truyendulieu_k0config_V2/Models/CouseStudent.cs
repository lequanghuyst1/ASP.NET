using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3_t5.Models
{
    public class CouseStudent
    {
        public Course course{ get; set; }
        public List<Student> students{ get; set; }

        public CouseStudent()
        {
            course = new Course();
            students = new List<Student>();
        }
    }
}