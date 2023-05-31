using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KTTX2.Models;
using PagedList;
namespace KTTX2.Controllers
{
    public class SanphamsController : Controller
    {
        private QLSanPhamDB db = new QLSanPhamDB();

        // GET: Sanphams
        public ActionResult Index(string searchName,string currentFilter, string sortOrder,int? page)
        {
            ViewBag.currentSort = sortOrder;
            ViewBag.SapTheoGia = sortOrder == "Gia" ? "gia_des" : "";
            var sanphams = db.Sanphams.Select(s => s);
            if (!String.IsNullOrEmpty(searchName))
            {
                sanphams = db.Sanphams.Where(s => s.Tenvd.Contains(searchName));
            }
            if(searchName != null)
            {
                page = 1;
            }
            else
            {
                currentFilter = searchName;
            }
            ViewBag.currentFilter = searchName;
            switch (sortOrder)
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
        [Route("shop/danhmuc/{MaDanhMuc=?}")]
        public ActionResult DisplayByMaDanhMuc(int MaDanhMuc,string searchName,string currentFilter,int?page,string sortOrder)
        {
            ViewBag.currentSort = sortOrder;

            ViewBag.SapTheoGia = sortOrder == "Gia" ? "gia_des" : "";
            ViewBag.TenDanhMuc = db.Danhmucs.Where(s => s.MaDanhmuc == MaDanhMuc).FirstOrDefault().TenDanhmuc;
            var sanphams = db.Sanphams.Where(p => p.MaDanhmuc == MaDanhMuc);
            if (!String.IsNullOrEmpty(searchName))
            {
                sanphams = db.Sanphams.Where(s => s.Tenvd.Contains(searchName));
            }
            if(searchName != null)
            {
                page = 1;
            }
            else
            {
                currentFilter = searchName;
            }
            ViewBag.currentFilter = searchName;
            switch (sortOrder)
            {
                case "Gia":
                    sanphams = sanphams.OrderByDescending(s => s.Giatien);
                    break;

                default:
                    sanphams = sanphams.OrderBy(s => s.Giatien);
                    break;
            }
            int pageSize = 6;
            int pageNumer = (page ?? 1);
            return View(sanphams.ToPagedList(pageNumer, pageSize));
        }
        // GET: Sanphams/Details/5
        [Route("shop/sanpham/{Mavd=?}")]
        /*public ActionResult DetailSanpham(int? Mavd)
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
        }*/
        public ActionResult Details(int? Mavd)
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
