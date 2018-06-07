using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("CustomerHome", "Customers");
            }
            else if (User.IsInRole("Worker"))
            {
                return RedirectToAction("WorkerHome", "Workers");
            }           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Manage trash collection with this app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}