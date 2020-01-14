using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using WebMVCApp.Models;

namespace WebMVCApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public class Guest
        {
            public String Id { get; set; }
            public String Password { get; set; }
            public String Name { get; set; }
            public int Age { get; set; }
        }
        
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            String id = Request["id"];
            String password = Request["password"];

            String result = LoginManager.LoginCheck(id, password).ToString();
            ViewBag.Result = result;

            Guest guest = new Guest
            {
                Id = "아이디",
                Password = "패스워드",
                Name = "이름",
                Age = 20
            };
            
            ViewData["key"] = "호롤롤로";

            return View(guest);
        }

        public ActionResult Default()
        {
            List<String> list = new List<String>(){ "aa", "bb", "cc", "dd" };

            ViewBag.list = list;
            ViewData["aaaa"] = list;

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
