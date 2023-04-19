using System;
using System.Collections.Generic;
using System.ComponentModel;
 
using System.Linq;
using System.Web;

namespace WebApplication3_t5.Models
{
    public class Student
    {
        [DisplayName("Nhập mã sv")]
        public string sid{ get; set; }

        [DisplayName("Nhập tên")]
        public string name{ get; set; }
        [DisplayName("Nhập tuổi")]
        public int age{ get; set; }

        [DisplayName("Nhập địa chỉ")]
        public string addr{ get; set; }
        public Student()
        {

        }
        public Student(string sid, string name, int age, string addr)
        {
            this.sid = sid;
            this.name = name;
            this.age = age;
            this.addr = addr;
        }
    }
}