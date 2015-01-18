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
    public class OrderController : Controller
    {
        private AllDbContext db = new AllDbContext();

        // GET: /Order/
        public ActionResult Index()
        {
            return View(db.ProductOrderDbSet.ToList());
        }

        // GET: /Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productorder = db.ProductOrderDbSet.Find(id);
            if (productorder == null)
            {
                return HttpNotFound();
            }
            return View(productorder);
        }

        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ProductOrderId,Name,ContactNmbr,ProductNumbr,Address,Quentity,Size")] ProductOrder productorder)
        {
            if (ModelState.IsValid)
            {
                db.ProductOrderDbSet.Add(productorder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productorder);
        }

        // GET: /Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productorder = db.ProductOrderDbSet.Find(id);
            if (productorder == null)
            {
                return HttpNotFound();
            }
            return View(productorder);
        }

        // POST: /Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ProductOrderId,Name,ContactNmbr,ProductNumbr,Address,Quentity,Size")] ProductOrder productorder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productorder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productorder);
        }

        // GET: /Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productorder = db.ProductOrderDbSet.Find(id);
            if (productorder == null)
            {
                return HttpNotFound();
            }
            return View(productorder);
        }

        // POST: /Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductOrder productorder = db.ProductOrderDbSet.Find(id);
            db.ProductOrderDbSet.Remove(productorder);
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
