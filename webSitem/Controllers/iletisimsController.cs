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
    public class iletisimsController : Controller
    {
        private Context db = new Context();

        // GET: iletisims
        public ActionResult Index()
        {
            return View(db.AnaSAyfas.ToList());
        }

        // GET: iletisims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnaSayfa iletisim = db.AnaSAyfas.Find(id);
            if (iletisim == null)
            {
                return HttpNotFound();
            }
            return View(iletisim);
        }

        // GET: iletisims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: iletisims/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,baslik,telefon,mail")] AnaSayfa iletisim)
        {
            if (ModelState.IsValid)
            {
                db.AnaSAyfas.Add(iletisim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iletisim);
        }

        // GET: iletisims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnaSayfa iletisim = db.AnaSAyfas.Find(id);
            if (iletisim == null)
            {
                return HttpNotFound();
            }
            return View(iletisim);
        }

        // POST: iletisims/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,baslik,telefon,mail")] AnaSayfa iletisim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iletisim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iletisim);
        }

        // GET: iletisims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnaSayfa iletisim = db.AnaSAyfas.Find(id);
            if (iletisim == null)
            {
                return HttpNotFound();
            }
            return View(iletisim);
        }

        // POST: iletisims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnaSayfa iletisim = db.AnaSAyfas.Find(id);
            db.AnaSAyfas.Remove(iletisim);
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
