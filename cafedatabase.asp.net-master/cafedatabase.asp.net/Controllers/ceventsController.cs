using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cafedatabase.asp.net.Models;

namespace cafedatabase.asp.net.Controllers
{
    public class ceventsController : Controller
    {
        private cafedatabaseEntities db = new cafedatabaseEntities();

        // GET: cevents
        public ActionResult Index()
        {
            return View(db.cevents.ToList());
        }

        // GET: cevents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cevents cevents = db.cevents.Find(id);
            if (cevents == null)
            {
                return HttpNotFound();
            }
            return View(cevents);
        }

        // GET: cevents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cevents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,description,scheduled_on")] cevents cevents)
        {
            if (ModelState.IsValid)
            {
                db.cevents.Add(cevents);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cevents);
        }

        // GET: cevents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cevents cevents = db.cevents.Find(id);
            if (cevents == null)
            {
                return HttpNotFound();
            }
            return View(cevents);
        }

        // POST: cevents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,description,scheduled_on")] cevents cevents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cevents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cevents);
        }

        // GET: cevents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cevents cevents = db.cevents.Find(id);
            if (cevents == null)
            {
                return HttpNotFound();
            }
            return View(cevents);
        }

        // POST: cevents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cevents cevents = db.cevents.Find(id);
            db.cevents.Remove(cevents);
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
