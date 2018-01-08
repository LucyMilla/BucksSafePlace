using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BucksSafePlaceSite2.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
        public ActionResult FAQ()
        {
           

            return View();
        }
        public ActionResult Medical()
        {
           

            return View();
        }
        public ActionResult Logged()
        {
            return View();
        }
        [Authorize(Roles = "Admin")] 
        public ActionResult SystemTraining()
        {
            return View();
        }
      
    }
}