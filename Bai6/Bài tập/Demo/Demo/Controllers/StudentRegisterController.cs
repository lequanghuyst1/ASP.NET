using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class StudentRegisterController : Controller
    {
        // GET: StudentRegister
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Student s)
        {
            return View(s);
        }
    }
}