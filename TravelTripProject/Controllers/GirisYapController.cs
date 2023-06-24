using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            ViewBag.test = "";
            return View();
        }
    }
}