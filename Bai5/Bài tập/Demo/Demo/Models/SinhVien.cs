using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class SinhVien
    {
        public SinhVien(string iD, string name, double mark)
        {
            ID = iD;
            Name = name;
            Mark = mark;
        }
        public SinhVien()
        {

        }
        public String ID { get; set; }
        public String Name { get; set; }
        public double Mark { get; set; }
    }
}