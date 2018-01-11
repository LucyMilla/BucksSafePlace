using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BucksSafePlaceSite2.Controllers
{
    
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult About()
        {
            return View();
        }
        
        public ActionResult Contact()
        {          
            return View();
        }
              
        public ActionResult Medical()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult SystemTraining()
        {
            return View();
        }       

        [Authorize(Roles = "Admin")]
        public ActionResult Incidents()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Locations()
        {
            return View();
        }
       
       
        
    }
}