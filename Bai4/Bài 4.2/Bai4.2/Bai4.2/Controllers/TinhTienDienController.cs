using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4._2.Controllers
{
    public class TinhTienDienController : Controller
    {
        // GET: TinhTienDien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NhapThongTin()
        {
            return View();
        }
        public float TienDienPhaiTra()
        {
            ViewBag.hoten = Request["txtHoTen"];
            float sodien = int.Parse(Request["txtSomoi"]) - int.Parse(Request["txtSocu"]);
            ViewBag.sodien = sodien;
            float tiendien;
            if (sodien <= 100)
            {
                tiendien = sodien * 2000;
            }
            else if (sodien > 100 && sodien <= 150)
            {
                tiendien = 100 * 2000 + (sodien - 100) * 2500;
            }
            else if (sodien > 150 && sodien <= 200)
            {
                tiendien = 100 * 2000 + 50 * 2500 + (sodien - 150) * 3000;
            }
            else
            {
                tiendien = 100 * 2000 + 50 * 2500 + 50 * 3000 + (sodien - 200) * 4000;
            }
            return tiendien;
        }
        public ActionResult TienDien()
        {
            ViewBag.hoten = Request["txtHoTen"];
            float sodien = int.Parse(Request["txtSomoi"]) - int.Parse(Request["txtSocu"]);
            ViewBag.sodien = sodien;
            float tiendien;
            String check = Request["check_ho"];
            String loaidien = Request["loaidien"];
            if (check == "true")
            {
                tiendien = TienDienPhaiTra() * 90 / 100;
                if (loaidien == "Sinh hoạt")
                {
                    ViewBag.Tiendien = tiendien;
                }
                else if (loaidien == "Kinh doanh")
                {
                    ViewBag.Tiendien = tiendien * 1.2;
                }
                else if (loaidien == "Sản xuất")
                {
                    ViewBag.Tiendien = tiendien * 1.3;
                }
            }
            else
            {
                tiendien = TienDienPhaiTra();
                if (loaidien == "Sinh hoạt")
                {
                    ViewBag.Tiendien = tiendien;
                }
                else if (loaidien == "Kinh doanh")
                {
                    ViewBag.Tiendien = tiendien * 1.2;
                }
                else if (loaidien == "Sản xuất")
                {
                    ViewBag.Tiendien = tiendien * 1.3;
                }
            }
            return View();
            }
        }
    }
