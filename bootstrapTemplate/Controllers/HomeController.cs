using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootstrapTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult aboutUs()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();

        }

        public ActionResult contactUs()
        {
            return View();
        }

        public ActionResult portfolio()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }



    }
}