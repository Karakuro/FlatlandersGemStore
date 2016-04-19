using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlatlandersGemStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var g = Entities.StoreWarehouse.Gems;
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
    }
}