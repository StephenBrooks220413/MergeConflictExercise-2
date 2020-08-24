using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtremeToys.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        [Authorize]
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}