using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrianGorishekPersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SkillSets()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}