using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace NWACricket.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts";

            return View();
        }

        public ActionResult Teams()
        {
            ViewBag.Message = "Teams";
            return View();
        }

        public ActionResult Grounds()
        {
            ViewBag.Message = "Grounds";

            return View();
        }

        public ActionResult Players()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }

        public ActionResult ScoreCard()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }

        public ActionResult PointsTable()
        {
            return View();
        }

        public ActionResult NewsArticles()
        {
            return View();
        }

        public ActionResult LiveScores()
        {
            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult Round()
        {
            return this.View();
        }
    }
}
