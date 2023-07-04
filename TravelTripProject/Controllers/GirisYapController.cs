using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
       
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login( Admin admin)
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.Kullanici==admin.Kullanici && x.Sifre==admin.Sifre );
        
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }else
            {
                return View();
            }
        
        }



    }
}