using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        
        public ActionResult IndexTest()
        {
            return View();
        }

        public int onePlusTwo(int one, int two)
        {
            return one + two;
        }
    }
}
