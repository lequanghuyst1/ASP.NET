using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_t5.Models;

namespace WebApplication3_t5.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School

        
        public ActionResult Welcome()
        {
            return View();
        }

        //[Route("th/nhap")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        //[Route("th/tinhtoan")]
        public ActionResult Tinhtoan()
        {
            return View();
        }

        [HttpPost]
        //[Route("th/xem1sv")]
        public ActionResult DisplayAStudent(Student s)
        {
            return View(s);
        }

        //[Route("th/xemdssv")]
        public ActionResult DisplayListStudent()
        {
            List<Student> li = new List<Student>();
            li.Add(new Student("s01", "Lan", 19, "hn"));
            li.Add(new Student("s02", "Hoang", 20, "hp"));
            li.Add(new Student("s03", "Van Anh", 18, "hp"));
            li.Add(new Student("s04", "Tuan", 19, "hn"));

            return View(li);
        }

        //[Route("th/xemkhoahoc")]
        public ActionResult DisplayCouseStudent()
        {

            CouseStudent cs = new CouseStudent();
            cs.course.cid = "c01";
            cs.course.cname = "Java";

            List<Student> li = new List<Student>();
            li.Add(new Student("s01", "Lan", 19, "hn"));
            li.Add(new Student("s02", "Hoang", 20, "hp"));
            li.Add(new Student("s03", "Van Anh", 18, "hp"));
            li.Add(new Student("s04", "Tuan", 19, "hn"));

            cs.students = li;
            return View(cs);
             
        }
        //[Route("th/xem2dssv")]
        public ActionResult Display2ListStudent()
        {
           
            List<Student> li1 = new List<Student>();
            li1.Add(new Student("s01", "Lan", 19, "hn"));
            li1.Add(new Student("s02", "Hoang", 20, "hp"));
            li1.Add(new Student("s03", "Van Anh", 18, "hp"));
            li1.Add(new Student("s04", "Tuan", 19, "hn"));

            List<Student> li2 = new List<Student>();
            li2.Add(new Student("s08", "Mai Phuong", 19, "hn"));
            li2.Add(new Student("s09", "Long", 20, "hp"));
            li2.Add(new Student("s10", "Van Anh", 18, "hp"));
            li2.Add(new Student("s11", "Tuan", 19, "hn"));

            //ViewData, TempData

            ViewBag.li1 = li1;
            ViewBag.li2 = li2;

            return View();
                        
        }



    }
}