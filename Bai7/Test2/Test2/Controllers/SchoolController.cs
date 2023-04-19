using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult FormRegis()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DisplayAStudent(Student s)
        {

            return View(s);
        }
        public ActionResult Caculator()
        {
            return View();
        }
        public ActionResult DisplayListStudent()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            return View(lst);
        }
        public ActionResult Display2ListStudent()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            List<Student> lst2 = new List<Student>();
            lst2.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst2.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst2.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst2.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            ViewBag.lst1 = lst;
            ViewBag.lst2 = lst2;
            return View();
        }
        public ActionResult DisplayCouseStudent()
        {
            StudentCourse sc = new StudentCourse();
            sc.cs.CID = "C01";
            sc.cs.CName="Java";
            List<Student> lst = new List<Student>();
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            lst.Add(new Student("SV01", "Lê Quang Huy", "21", "Hà Nội"));
            sc.students = lst;
            return View(sc);
        }
    }
}