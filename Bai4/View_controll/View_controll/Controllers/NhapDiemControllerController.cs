using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_controll.Models;

namespace View_controll.Controllers
{
    public class NhapDiemControllerController : Controller
    {
        // GET: NhapDiemController
        public ActionResult Index()
        {
            return View();
        }



        //Từ controller sang view

        //Cách 1: use viewbag or viewdata[] 
        /*public ActionResult Detail()
        {
            ViewBag.id = "SV001";
            ViewBag.name = "Le Quang Huy";
            ViewData["mark"] = 9.5;
            return View();
        }*/

        //Cách 2: use model 

        /* public ActionResult Detail(SinhVien sv)
         {
             sv.id = "SV001";
             sv.name = "Le Quang Huy";
             sv.mark = 9.5;
             return View(sv);
         }*/


        //Transfer data to view from controller

        public ActionResult Detail()
        {
            int a = int.Parse(Request["soa"]);
            int b = int.Parse(Request["sob"]);
            String cal = Request["cala"];
            ViewBag.c = cal;
            if (cal == "Cộng")
            {
                ViewBag.kq = a + b;
            }
            else if (cal == "Trừ")
            {
                ViewBag.kq = a - b;
            }
            else if (cal == "Nhân")
            {
                ViewBag.kq = a * b;
            }
            else if (cal == "Chia")
            {
                ViewBag.kq = (float)a / b;
            }
            return View();
        }
        /*public ActionResult Xuly()
        {
            String ma = Request["Id"];
            String ten = Request["Name"];
            double diem = Convert.ToDouble(Request["Mark"]);
            ViewBag.ma = ma;
            ViewBag.ten = ten;
            ViewBag.diem = diem;
            return View();
        }*/

        /*public ActionResult Xuly(FormCollection data)
        {
            String ma = data["Id"];
            String ten = data["Name"];
            double diem = Convert.ToDouble(data["Mark"]);
            ViewBag.ma = ma;
            ViewBag.ten = ten;
            ViewBag.diem = diem;
            return View();
        }*/

        /*public ActionResult Xuly(SinhVien sv)
        {

            ViewBag.ma = sv.id;
            ViewBag.ten = sv.name;
            ViewBag.diem = sv.mark;
            return View();
        }*/

        public ActionResult Xuly()
        {

            int a = int.Parse(Request["soa"]);
            int b = int.Parse(Request["sob"]);
            String cal = Request["cala"];
            ViewBag.c = cal;
            if(cal == "Cộng")
            {
                ViewBag.kq = a+b;
            }
            else if(cal == "Trừ")
            {
                ViewBag.kq = a - b;
            }
            else if(cal == "Nhân")
            {   
                ViewBag.kq = a * b;
            }
            else if(cal == "Chia"){
                ViewBag.kq = (float)a / b;
            }
            return View();
        }
    }
}