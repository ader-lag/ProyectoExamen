using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoVotaciones.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PresidentsCandidate()
        {
            ViewBag.Message = "Your Candidate President page.";

            return View();
        }

        public ActionResult CandidateVicepresidents()
        {
            ViewBag.Message = "Your Candidate VicePresident´s page.";

            return View();
        }
    }
}