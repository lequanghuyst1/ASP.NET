using Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(SinhVien sv)
        {
            string path = Server.MapPath("~/StudentInfo.txt");
            string[] lines = { sv.ID, sv.Name, sv.Mark.ToString() };
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.HanhDong = "Đã ghi từ file";
            return View("Index",sv);
        }
        public ActionResult Open(SinhVien sv)
        {
            string path = Server.MapPath("~/StudentInfo.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            sv.ID = lines[0];
            sv.Name = lines[1];
            sv.Mark = double.Parse(lines[2]);
            ViewBag.ThongTin = "Mã sinh viên: " + sv.ID + "Họ tên: " + sv.Name + "Điểm: " + sv.Mark;
            // SinhVien sv = new SinhVien(lines[0], lines[1], double.Parse(lines[2]));
            return View("Index",sv);
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