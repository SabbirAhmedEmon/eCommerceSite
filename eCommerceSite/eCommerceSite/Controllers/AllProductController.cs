using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eCommerceSite.Models;

namespace eCommerceSite.Controllers
{
    public class AllProductController : Controller
    {
        private AllDbContext db = new AllDbContext();

        // GET: /AllProduct/
        public ActionResult Index()
        {
            return View(db.AllProductseDbSet.ToList());
        }

        // GET: /AllProduct/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllProducts allproducts = db.AllProductseDbSet.Find(id);
            if (allproducts == null)
            {
                return HttpNotFound();
            }
            return View(allproducts);
        }

        // GET: /AllProduct/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /AllProduct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="AllProductsId")] AllProducts allproducts)
        {
            if (ModelState.IsValid)
            {
                db.AllProductseDbSet.Add(allproducts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allproducts);
        }

        // GET: /AllProduct/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllProducts allproducts = db.AllProductseDbSet.Find(id);
            if (allproducts == null)
            {
                return HttpNotFound();
            }
            return View(allproducts);
        }

        // POST: /AllProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="AllProductsId")] AllProducts allproducts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allproducts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allproducts);
        }

        // GET: /AllProduct/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllProducts allproducts = db.AllProductseDbSet.Find(id);
            if (allproducts == null)
            {
                return HttpNotFound();
            }
            return View(allproducts);
        }

        // POST: /AllProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllProducts allproducts = db.AllProductseDbSet.Find(id);
            db.AllProductseDbSet.Remove(allproducts);
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
