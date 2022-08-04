using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa

        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSAyfas.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.Ikons.ToList();
            return PartialView(deger);
        }

    }
}