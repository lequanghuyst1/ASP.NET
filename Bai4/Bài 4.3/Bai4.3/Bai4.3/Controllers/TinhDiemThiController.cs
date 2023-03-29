using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4._3.Controllers
{
    public class TinhDiemThiController : Controller
    {
        // GET: TinhDiemThi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NhapThongTin()
        {
            return View();
        }
        public double TongDiem()
        {
            double diemkhuvuc = 0;
            String khuvuc = Request["khuvuc"];
            if (khuvuc == "Khu A")
            {
                diemkhuvuc = 1;
            }
            else if (khuvuc == "Khu B")
            {
                diemkhuvuc = 2;
            }
            else if (khuvuc == "Khu C")
            {
                diemkhuvuc = 3;
            }
            double diem = 0;
            diem = double.Parse(Request["DiemToan"]) + double.Parse(Request["DiemLy"]) + double.Parse(Request["DiemHoa"])+diemkhuvuc;
            if (Request["check_ho"] == "true")
            {
                diem = diem + 1;
            }
            return diem;
        }
        public String ketqua()
        {
            String ketqua = "";
            if (TongDiem() >= 20)
            {
                ketqua += "Đỗ đại học";
            }
            else if(TongDiem() >=15 && TongDiem() < 20)
            {
                ketqua += "Đỗ cao đẳng";
            }
            else if (TongDiem() >= 10 && TongDiem() < 15){
                ketqua += "Đỗ trung cấp";
            }
            else
            {
                ketqua += "Thi trượt";
            }
            return ketqua;
        }
        public ActionResult HienThi()
        {
            ViewBag.hoten = Request["txtHoTen"];
            ViewBag.tongdiem = TongDiem();
            ViewBag.ketqua = ketqua();
            return View();
        }
    }
}