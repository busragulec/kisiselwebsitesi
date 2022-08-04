using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class HakkindaController : Controller
    {
        // GET: Hakkinda
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.hakkindas.ToList();
            return View(deger);
        }
    }
}