using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai5._3.Controllers
{
    public class UpLoadMailController : Controller
    {
        // GET: UpLoadMail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(HttpPostedFileBase[] files)
        {
            foreach(var file in files)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/FileUpLoad"), fileName);
                file.SaveAs(path);

            }
            ViewBag.HanhDong = "Gửi thành công";

            return View("Index");
        }
    }
}