using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotoTour_Capstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewsFeed()
        {
            ViewBag.Message = "News Feed";

            return View();
        }

        public ActionResult Maps()
        {
            ViewBag.Message = "Maps";

            return View();
        }
    }
}