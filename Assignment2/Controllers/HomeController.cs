using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.Controllers;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Information and Technology College.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact page.";

            return View();
        }
      
        }
    }
