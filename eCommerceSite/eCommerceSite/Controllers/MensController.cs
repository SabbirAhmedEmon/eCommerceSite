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
    public class MensController : Controller
    {
        private AllDbContext db = new AllDbContext();

        // GET: /Mens/
        public ActionResult Index()
        {
            return View(db.MensProductDbSet.ToList());
        }

        // GET: /Mens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MensProduct mensproduct = db.MensProductDbSet.Find(id);
            if (mensproduct == null)
            {
                return HttpNotFound();
            }
            return View(mensproduct);
        }

        // GET: /Mens/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: /Mens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MensProductId")] MensProduct mensproduct)
        {
            if (ModelState.IsValid)
            {
                db.MensProductDbSet.Add(mensproduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mensproduct);
        }

        // GET: /Mens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MensProduct mensproduct = db.MensProductDbSet.Find(id);
            if (mensproduct == null)
            {
                return HttpNotFound();
            }
            return View(mensproduct);
        }
        public ActionResult M001Details()
        {
            return View();
        }
        public ActionResult M002Details()
        {
            return View();
        }
        public ActionResult M003Details()
        {
            return View();
        }
        // POST: /Mens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MensProductId")] MensProduct mensproduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mensproduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mensproduct);
        }

        // GET: /Mens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MensProduct mensproduct = db.MensProductDbSet.Find(id);
            if (mensproduct == null)
            {
                return HttpNotFound();
            }
            return View(mensproduct);
        }

        // POST: /Mens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MensProduct mensproduct = db.MensProductDbSet.Find(id);
            db.MensProductDbSet.Remove(mensproduct);
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
