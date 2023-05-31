using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private SanPhamDB db = new SanPhamDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplaySuplier(int? page)
        {
            var suppplies = db.Nha_CC.Select(s => s);
            suppplies = suppplies.OrderBy(s => s.MaNCC);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(suppplies.ToPagedList(pageNumber,pageSize));
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