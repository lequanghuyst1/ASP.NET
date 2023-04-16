using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_controll.Models
{
    public class SinhVien
    {
        public SinhVien(string id, string name, double mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public SinhVien()
        {

        }
        public string id { set; get; }
        public string name { set; get; }

        public double mark { set; get; }
    }
}