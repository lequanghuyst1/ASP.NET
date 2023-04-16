using Bai7._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai7._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Regis(FormCollection f)
        {
            Employee e = new Employee();
            e.FirstName = f["FirstName"];
            e.LastName = f["LastName"];
            e.Email = f["Email"];
            e.Password = f["Password"];

            if(f["lst"] == "Hà nội")
            {
                e.City = "Hà nội";
            }
            else if(f["lst"] == "Đà Nẵng")
            {
                e.City = "Đà Nẵng";
            }
            else if (f["lst"] == "Gia Lai")
            {
                e.City = "Gia Lai";
            }
            e.Gender = f["Gender"];
            return View(e);
        }


    }
}