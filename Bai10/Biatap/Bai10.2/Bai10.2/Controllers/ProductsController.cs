using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bai10._2.Models;
using PagedList;

namespace Bai10._2.Controllers
{
    public class ProductsController : Controller
    {
        private WinStoreDB db = new WinStoreDB();

        // GET: Products
        public ActionResult Index(string sort,string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sort;
            ViewBag.SapTheoTen = String.IsNullOrEmpty(sort) ? "name_des" : "";
            ViewBag.SapTheoGia = sort == "Gia" ? "gia_des" : "Gia";
            ViewBag.SapTheoID = sort == "ID" ? "ID_des" : "ID";
            string Ten = Request["searchString"];
            var products = db.Products.Select(p => p);
            if (!String.IsNullOrEmpty(Ten))
            {
               products = db.Products.Where(s=>s.ProductName.Contains(Ten));
            }
            decimal gia = decimal.Parse(Request["searchPrice"]);
            
            if(Ten != null)
            {
                page = 1;
            }
            else
            {
                Ten = currentFilter;
            }
            ViewBag.CurrentFilter = Ten;
            switch (sort)
            {
                case "name_des":
                    products = products.OrderByDescending(s=>s.ProductName);
                    break;
                case "gia_des":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                case "Gia":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "ID_des":
                    products = products.OrderByDescending(s => s.ProductID);
                    break;
                case "ID":
                    products = products.OrderBy(s => s.ProductID);
                    break;
                default:
                    products = products.OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber,pageSize));
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
