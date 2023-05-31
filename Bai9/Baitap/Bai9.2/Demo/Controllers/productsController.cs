using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class productsController : Controller
    {
        private shop2dbContext db = new shop2dbContext();

        // GET: products
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.category);
            return View(products.ToList());
        }

        // GET: products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: products/Create
        public ActionResult Create()
        {
            ViewBag.catid = new SelectList(db.categories, "catid", "catname");
            return View();
        }

        // POST: products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "proid,proname,price,stock,image,description,catid")] product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product.image = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        product.image = FileName;
                    }
                    db.products.Add(product);
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu " + ex.Message;
                ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
                return View(product);
            }
        }

        // GET: products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
            return View(product);
        }

        // POST: products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "proid,proname,price,stock,image,description,catid")] product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["ImageFile"];
                    if(f!= null)
                    {
                        var fname = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/Images/" + fname);
                        f.SaveAs(UploadPath);
                        product.image = fname;
                    }
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }
                return RedirectToAction("Index");

            }
            catch(Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu " + ex.Message;
                ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
                return View(product);
            }
     

        }

        // GET: products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.products.Find(id);
            db.products.Remove(product);
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
