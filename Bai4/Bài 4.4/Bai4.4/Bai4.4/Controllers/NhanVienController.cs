using Bai4._4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4._4.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public int NCTL(NhanVien nv)
        {
            int i = 0;

            if (nv.NgayCong < 25)
            {
                i = nv.NgayCong;
            }
            else
            {
                i = (nv.NgayCong - 25) * 2 + 25;
            }
            return i;
        }
        public double PhuCap(NhanVien nv)
        {
            double phucap = 0;
            if(nv.ChucVu =="Trưởng phòng")
            {
                phucap = 500000;
            }
            else if(nv.ChucVu == "Phó phòng")
            {
                phucap = 300000;
            }
            return phucap;
        }
        public double TienLinh(NhanVien nv)
        {
            double tienlinh = 0;
            tienlinh = nv.BacLuong * 650000 * NCTL(nv) + PhuCap(nv);
            return tienlinh;
        }
        public ActionResult NhapThongTin()
        {
            return View();
        }
        public ActionResult HienThi(NhanVien nv)
        {
            ViewBag.maNV = nv.MaNV;
            ViewBag.ngayCong = nv.NgayCong;
            ViewBag.tienLinh = TienLinh(nv);
            return View();
        }
    }
}