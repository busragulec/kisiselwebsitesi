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
    public class egitimsController : Controller
    {
        private Context db = new Context();

        // GET: egitims
        public ActionResult Index()
        {
            return View(db.egitims.ToList());
        }

        // GET: egitims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            egitim egitim = db.egitims.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // GET: egitims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: egitims/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,baslik,ilkokul,ortaokul,lise,uni,bolum")] egitim egitim)
        {
            if (ModelState.IsValid)
            {
                db.egitims.Add(egitim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(egitim);
        }

        // GET: egitims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            egitim egitim = db.egitims.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // POST: egitims/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,baslik,ilkokul,ortaokul,lise,uni,bolum")] egitim egitim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egitim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egitim);
        }

        // GET: egitims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            egitim egitim = db.egitims.Find(id);
            if (egitim == null)
            {
                return HttpNotFound();
            }
            return View(egitim);
        }

        // POST: egitims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            egitim egitim = db.egitims.Find(id);
            db.egitims.Remove(egitim);
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
