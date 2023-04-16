using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_controll.Models;

namespace View_controll.Controllers
{
    public class NhapThongTinController : Controller
    {
        // GET: NhapThongTin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result1(String ID,string name,double mark)
        {
            SinhVien sv = new SinhVien(ID, name, mark);
        
            return View(sv);
        }
        public ActionResult Result2(SinhVien sv)
        {

            return View("Result1",sv);
        }
    }
}