using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.iletisims.ToList();
            return View(deger);
        }
    }
}