using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test3.Models;

namespace Test3.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Display(Student s)
        {
            return View(s);
        }
        public ActionResult DisplayAList()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));

            return View(lst);
        }
        public ActionResult Display2List()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst.Add(new Student("SV01", "Huy", "21", "Ha Noi"));

            List<Student> lst2 = new List<Student>();
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            ViewBag.lst1 = lst;
            ViewBag.lst2 = lst2;
            return View();
        }
        public ActionResult StudentCourse()
        {
            StudentCourse sc = new StudentCourse();
            sc.course.CID = 01;
            sc.course.CName = "Java";
            List<Student> lst2 = new List<Student>();
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            lst2.Add(new Student("SV01", "Huy", "21", "Ha Noi"));
            sc.Students = lst2;
            return View(sc);
        }
    }
}