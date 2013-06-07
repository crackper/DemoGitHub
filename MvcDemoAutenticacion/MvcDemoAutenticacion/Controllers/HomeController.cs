using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemoAutenticacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "WEY";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult validar(int id)
        {
            return View();
        }
    }
}
