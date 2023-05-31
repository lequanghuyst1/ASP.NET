using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;
using BaiTest.Models;
using PagedList;
namespace BaiTest.Controllers
{
    public class SanphamsController : Controller
    {
        private QLSanPhamDB db = new QLSanPhamDB();

        // GET: Sanphams
        public ActionResult Index(string sortOder,string searchName,string currenFilter,int? page)
        {
            ViewBag.CurrentSort = sortOder;
            ViewBag.SapTheoGia = sortOder == "Gia" ? "gia_des" : "";
            var sanphams = db.Sanphams.Select(s => s);
            
            if (!String.IsNullOrEmpty(searchName))
            {
                sanphams = db.Sanphams.Where(p => p.Tenvd.Contains(searchName));
            }
            if (searchName != null)
            {
                page = 1;
            }
            else
            {
                searchName = currenFilter;
            }
            ViewBag.CurrentFilter = searchName;
            string giatien = Request["searchPrice"];
            if (!String.IsNullOrEmpty(giatien))
            {
                sanphams = db.Sanphams.Where(p => p.Giatien.ToString() == giatien);
            }
            if (giatien != null)
            {
                page = 1;
            }
            else
            {
                giatien = currenFilter;
            }
            ViewBag.CurrentFilter = giatien;
            switch (sortOder)
            {
                case "Gia":
                    sanphams = sanphams.OrderByDescending(s => s.Giatien);
                    break;
               
                default:
                    sanphams = sanphams.OrderBy(s=>s.Giatien);
                    break;
            }
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(sanphams.ToPagedList(pageNumber,pageSize));
        }
        [Route("shop/danhmuc/{MaDanhmuc=?}")]
        public ActionResult ProductByCategoryID(int MaDanhmuc, string sortOder, string searchName, string currenFilter, int? page)
        {
            ViewBag.CurrentSort = sortOder;
            ViewBag.SapTheoGia = sortOder == "Gia" ? "gia_des" : "";
            ViewBag.TenDanhMuc = db.Danhmucs.Where(s => s.MaDanhmuc == MaDanhmuc).FirstOrDefault().TenDanhmuc;
            var sanphams = db.Sanphams.Where(p => p.MaDanhmuc == MaDanhmuc);

            if (!String.IsNullOrEmpty(searchName))
            {
                sanphams = db.Sanphams.Where(p => p.Tenvd.Contains(searchName));
            }
            switch (sortOder)
            {
                case "Gia":
                    sanphams = sanphams.OrderByDescending(s => s.Giatien);
                    break;

                default:
                    sanphams = sanphams.OrderBy(s => s.Giatien);
                    break;
            }
            int pageSize = 8;
            int pageNumber = (page ?? 1);
           
            return View(sanphams.ToPagedList(pageNumber, pageSize));

        }
        [Route("shop/sanpham/{Mavd=?}")]
        /*public ActionResult DetailSanpham(int Mavd)
        {
            Sanpham sp = db.Sanphams.Where(s => s.Mavd == Mavd);
            return View(sp);
        }*/
        // GET: Sanphams/Details/5

        public ActionResult Details(int Mavd)
        {
            if (Mavd == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(Mavd);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // GET: Sanphams/Create
        public ActionResult Create()
        {
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc");
            return View();
        }

        // POST: Sanphams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mavd,Tenvd,Mota,TenAnh,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                var f = Request.Files["ImageFile"];
                if(f!=null && f.ContentLength > 0)
                {
                    string fname = System.IO.Path.GetFileName(f.FileName);
                    string fpath = Server.MapPath("~/Content/Images/" + fname);
                    f.SaveAs(fpath);
                    sanpham.Mota = fname;
                }
                db.Sanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // GET: Sanphams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // POST: Sanphams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mavd,Tenvd,Mota,TenAnh,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            
            {
                var f = Request.Files["ImagePath"];
                if(f != null && f.ContentLength > 0)
                {
                    string fname = System.IO.Path.GetFileName(f.FileName);
                    string fpath = Server.MapPath("~/Content/Images/" + fname);
                    f.SaveAs(fpath);
                    sanpham.Mota = fname;   
                }
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // GET: Sanphams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // POST: Sanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sanpham sanpham = db.Sanphams.Find(id);
            db.Sanphams.Remove(sanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
