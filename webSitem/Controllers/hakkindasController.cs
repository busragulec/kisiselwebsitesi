using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class hakkindasController : Controller
    {
        private Context db = new Context();

        // GET: hakkindas
        public ActionResult Index()
        {
            return View(db.hakkindas.ToList());
        }

        // GET: hakkindas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hakkinda hakkinda = db.hakkindas.Find(id);
            if (hakkinda == null)
            {
                return HttpNotFound();
            }
            return View(hakkinda);
        }

        // GET: hakkindas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hakkindas/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,baslik,metin")] hakkinda hakkinda)
        {
            if (ModelState.IsValid)
            {
                db.hakkindas.Add(hakkinda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hakkinda);
        }

        // GET: hakkindas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hakkinda hakkinda = db.hakkindas.Find(id);
            if (hakkinda == null)
            {
                return HttpNotFound();
            }
            return View(hakkinda);
        }

        // POST: hakkindas/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,baslik,metin")] hakkinda hakkinda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hakkinda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hakkinda);
        }

        // GET: hakkindas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hakkinda hakkinda = db.hakkindas.Find(id);
            if (hakkinda == null)
            {
                return HttpNotFound();
            }
            return View(hakkinda);
        }

        // POST: hakkindas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hakkinda hakkinda = db.hakkindas.Find(id);
            db.hakkindas.Remove(hakkinda);
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
