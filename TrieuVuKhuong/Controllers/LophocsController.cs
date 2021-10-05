using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrieuVuKhuong.Models;

namespace TrieuVuKhuong.Controllers
{
    public class LophocsController : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: Lophocs
        public ActionResult Index()
        {
            return View(db.LopHocs.ToList());
        }

        // GET: Lophocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lophoc = db.LopHocs.Find(id);
            if (lophoc == null)
            {
                return HttpNotFound();
            }
            return View(lophoc);
        }

        // GET: Lophocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lophocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] Lophoc lophoc)
        {
            if (ModelState.IsValid)
            {
                db.LopHocs.Add(lophoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lophoc);
        }

        // GET: Lophocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lophoc = db.LopHocs.Find(id);
            if (lophoc == null)
            {
                return HttpNotFound();
            }
            return View(lophoc);
        }

        // POST: Lophocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] Lophoc lophoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lophoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lophoc);
        }

        // GET: Lophocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lophoc lophoc = db.LopHocs.Find(id);
            if (lophoc == null)
            {
                return HttpNotFound();
            }
            return View(lophoc);
        }

        // POST: Lophocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lophoc lophoc = db.LopHocs.Find(id);
            db.LopHocs.Remove(lophoc);
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
