using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvcBasic.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Forward Index Page";
            return View();
        }

        public ActionResult Context()
        {
            return Redirect("/Home/About");
        }

        public ActionResult About()
        {
            return View();
        }
        
    }
}
