using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Student
    {
        

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public string Subjects { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Comment { get; set; }

        public Student()
        {

        }
        public Student(string name, string gender, string email, string address, string subjects, string username, string password, string comment)
        {
            Name = name;
            Gender = gender;
            Email = email;
            Address = address;
            Subjects = subjects;
            Username = username;
            Password = password;
            Comment = comment;
        }
    }
}