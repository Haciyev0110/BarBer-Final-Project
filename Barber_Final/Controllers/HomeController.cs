using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Barber_Final.Models;
using Barber_Final.Vm;

namespace Barber_Final.Controllers
{
    public class HomeController : Controller
    {
        BarberShOWEntities db = new BarberShOWEntities();
        

        public ActionResult Index()
        {
            ViewModel mnv = new ViewModel();

            mnv.mainSlider = db.MainSlider.ToList();
            mnv.Aboutus = db.AboutCenter.First();
            mnv.Detalis = db.About_details.First();
            mnv.House = db.Working_House.ToList();
            mnv.Servicesss = db.Our_Services.First();
            mnv.Cartinca = db.Our_Cartinca.ToList();
            mnv.Apoints = db.Appoint.First();


            return View(mnv);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}