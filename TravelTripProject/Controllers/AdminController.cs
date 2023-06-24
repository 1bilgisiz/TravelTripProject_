using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }



        [HttpGet]
        public ActionResult YeniBlog()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var bul = c.Blogs.Find(id);
            return View("BlogGetir", bul);
        }


        public ActionResult BlogGüncelle(Blog b)
        {
            var bul = c.Blogs.Find(b.ID);
            bul.Aciklama = b.Aciklama;
            bul.Baslik = b.Baslik;
            bul.BlogImage = b.BlogImage;
            bul.tarih = b.tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public ActionResult YorumlarListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);

        }


        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumlarListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yl = c.Yorumlars.Find(id);
            return View("YorumGetir", yl);
        }

        public ActionResult YorumGüncelle(Yorumlar y)
        {

            var bul = c.Yorumlars.Find(y.ID);
            bul.KullaniciAdi = y.KullaniciAdi;
            bul.Mail = y.Mail;
            bul.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumlarListesi");
        }
    }
}