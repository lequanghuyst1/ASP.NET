using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public String ChaoMung(String ten, int sl=1)
        {
            return HttpUtility.HtmlEncode("Xin chào " + ten + "Số lần là "+sl);
        }
    }
}