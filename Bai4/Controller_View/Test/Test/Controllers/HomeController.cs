using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> li = new List<Student>();
            li.Add(new Student("SV01","Lê Quang Huy","Hà Nội"));
            li.Add(new Student("SV02", "Lê Thanh Hải", "Hà Nội"));
            li.Add(new Student("SV03", "Lê Tuấn Kiệt", "Hà Nội"));
            ViewBag.lst = li;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Course c = new Course("1", "ASP.NET");
            List<Student> li = new List<Student>();
            li.Add(new Student("SV01", "Lê Quang Huy", "Hà Nội"));
            li.Add(new Student("SV02", "Lê Thanh Hải", "Hà Nội"));
            li.Add(new Student("SV03", "Lê Tuấn Kiệt", "Hà Nội"));
            Course_Student ct = new Course_Student(c, li);
            return View(ct);
        }
    }
}