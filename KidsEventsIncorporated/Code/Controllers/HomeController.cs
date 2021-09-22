using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidsEventsIncorporated.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Over KEI - Kids Events Incorporated.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacteer ons!";

            return View();
        }
    }
}