using Bai5._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai5._2.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(Mail m)
        {
            string path = Server.MapPath("~/ MailInfo.txt");
            string[] info = { m.mailFrom, m.password, m.mailTo, m.subject, m.message };
            System.IO.File.WriteAllLines(path, info);
            ViewBag.HanhDong = "Gửi thành công";
            string[] lines = System.IO.File.ReadAllLines(path);
            m.mailFrom = lines[0];
            m.password = lines[1];
            m.mailTo = lines[2];
            m.subject = lines[3];
            m.message = lines[4];
            ViewBag.mailFrom = m.mailFrom;
            ViewBag.password = m.password;
            ViewBag.mailTo = m.mailTo;
            ViewBag.subject = m.subject;
            ViewBag.message = m.message;
            return View("Index");
        }
        
    }
}