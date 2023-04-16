using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai6._3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Day = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.Hour = DateTime.Now.Hour;
            ViewBag.Minute = DateTime.Now.Minute;
            ViewBag.Second = DateTime.Now.Second;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}