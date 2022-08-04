using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using webSitem.Models.sinif;

namespace webSitem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context(); //Sql bağlantısı

        [Authorize] //Güvenlik için yönlendirme
        public ActionResult Index()
        {
            var deger = c.AnaSAyfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSAyfas.Find(id);
            return View("AnaSayfaGetir", ag);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnaSayfaGüncelle(AnaSayfa anasayfa, HttpPostedFileBase profil, HttpPostedFileBase resim1, HttpPostedFileBase resim2, HttpPostedFileBase resim3, HttpPostedFileBase reklam1, HttpPostedFileBase reklam2)
        {
            
            if (ModelState.IsValid)
            {
                if (profil != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.profil)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.profil));
                    }

                    WebImage img = new WebImage(profil.InputStream);
                    FileInfo imginfo = new FileInfo(profil.FileName);
                    string imgname = profil.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.profil = "/web-Admin/resim/" + imgname;

                   

                }

                if (resim1 != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.resim1)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.resim1));
                    }

                    WebImage img = new WebImage(resim1.InputStream);
                    FileInfo imginfo = new FileInfo(resim1.FileName);
                    string imgname = resim1.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.resim1 = "/web-Admin/resim/" + imgname;

                }

                if (resim2 != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.resim2)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.resim2));
                    }

                    WebImage img = new WebImage(resim2.InputStream);
                    FileInfo imginfo = new FileInfo(resim2.FileName);
                    string imgname = resim2.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.resim2 = "/web-Admin/resim/" + imgname;

                }

                if (resim3 != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.resim3)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.resim3));
                    }

                    WebImage img = new WebImage(resim3.InputStream);
                    FileInfo imginfo = new FileInfo(resim3.FileName);
                    string imgname = resim3.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.resim3 = "/web-Admin/resim/" + imgname;

                }

                if (reklam1 != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.reklam1)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.reklam1));
                    }

                    WebImage img = new WebImage(reklam1.InputStream);
                    FileInfo imginfo = new FileInfo(reklam1.FileName);
                    string imgname = reklam1.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.reklam1 = "/web-Admin/resim/" + imgname;

                }

                if (reklam2 != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(anasayfa.reklam2)))
                    {
                        System.IO.File.Delete(Server.MapPath(anasayfa.reklam2));
                    }

                    WebImage img = new WebImage(reklam2.InputStream);
                    FileInfo imginfo = new FileInfo(reklam2.FileName);
                    string imgname = reklam2.FileName + imginfo.Extension;
                    //img.Resize(100, 100);
                    img.Save("~/web-Admin/resim/" + imgname);

                    anasayfa.reklam2 = "/web-Admin/resim/" + imgname;

                }

                c.Entry(anasayfa).State = EntityState.Modified;
                c.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anasayfa);
        }


        //public ActionResult AnaSayfaGüncelle(AnaSayfa x, HttpPostedFileBase profil, HttpPostedFileBase resim1, HttpPostedFileBase resim2, HttpPostedFileBase resim3, HttpPostedFileBase reklam1, HttpPostedFileBase reklam2)
        //{
        //    if (ModelState.IsValid)//Model doğrulandıysa
        //    {
        //        var ag = c.AnaSAyfas.Find(x);

        //        if (profil != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.profil)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.profil));
        //            }
        //            WebImage img = new WebImage(profil.InputStream);
        //            FileInfo imginfo = new FileInfo(profil.FileName);
        //            string imgName = profil.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.profil = "~/resimler/" + imgName;
        //        }

        //        if (resim1 != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.resim1)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.resim1));
        //            }
        //            WebImage img = new WebImage(resim1.InputStream);
        //            FileInfo imginfo = new FileInfo(resim1.FileName);
        //            string imgName = resim1.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.resim1 = "~/resimler/" + imgName;
        //        }

        //        if (resim2 != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.resim2)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.resim2));
        //            }
        //            WebImage img = new WebImage(resim2.InputStream);
        //            FileInfo imginfo = new FileInfo(resim2.FileName);
        //            string imgName = resim2.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.resim2 = "~/resimler/" + imgName;
        //        }

        //        if (resim3 != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.resim3)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.resim3));
        //            }
        //            WebImage img = new WebImage(resim3.InputStream);
        //            FileInfo imginfo = new FileInfo(resim3.FileName);
        //            string imgName = resim3.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.resim3 = "~/resimler/" + imgName;
        //        }

        //        if (reklam1 != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.reklam1)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.reklam1));
        //            }
        //            WebImage img = new WebImage(reklam1.InputStream);
        //            FileInfo imginfo = new FileInfo(reklam1.FileName);
        //            string imgName = resim3.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.reklam1 = "~/resimler/" + imgName;
        //        }

        //        if (reklam2 != null)//Gelen resim boş değilse
        //        {
        //            if (System.IO.File.Exists(Server.MapPath(ag.reklam2)))
        //            {
        //                System.IO.File.Delete(Server.MapPath(ag.reklam2));
        //            }
        //            WebImage img = new WebImage(reklam2.InputStream);
        //            FileInfo imginfo = new FileInfo(reklam2.FileName);
        //            string imgName = reklam2.FileName + imginfo.Extension;
        //            img.Resize(100, 100);
        //            img.Save("~/resimler/" + imgName);

        //            ag.reklam2 = "~/resimler/" + imgName;
        //      }
        //        ag.isim = x.isim;
        //        //ag.profil = x.profil;
        //        //ag.resim1 = x.resim1;
        //        //ag.resim2 = x.resim2;
        //        //ag.resim3 = x.resim3;
        //        ag.unvan = x.unvan;
        //        ag.aciklama = x.aciklama;
        //        ag.iletisim = x.iletisim;
        //        //ag.reklam1 = x.reklam1;
        //        ag.reklamlink1 = x.reklamlink1;
        //        //ag.reklam2 = x.reklam2;
        //        ag.reklamlink2 = x.reklamlink2;
        //        c.SaveChanges();
               
        //    }
        //    return RedirectToAction("Index");
        //}
        public ActionResult ikonListesi()
        {
            var deger = c.Ikons.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult Yeniikon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniikon(ikons p)
        {
            c.Ikons.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.Ikons.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(ikons x)
        {
            var ig = c.Ikons.Find(x.ikonid);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.Ikons.Find(id);
            c.Ikons.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
    }
}