using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.egitims.ToList();
            return View(deger);
        }
    }
}