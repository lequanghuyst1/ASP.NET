using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Student
    {
       
        public String MaSV { get; set; }
        public String HoTen { get; set; }
        public String QueQuan { get; set; }
        public Student(string maSV, string hoTen, string queQuan)
        {
            MaSV = maSV;
            HoTen = hoTen;
            QueQuan = queQuan;
        }

    }
}