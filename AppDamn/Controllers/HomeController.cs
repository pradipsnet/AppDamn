using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using System.Web.Mvc;

namespace AppDamn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData.Add("Initial", "Mr.");
            ViewBag.MyName = "Pradip";
            TempData.Add("LastName", " Kumar");
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}