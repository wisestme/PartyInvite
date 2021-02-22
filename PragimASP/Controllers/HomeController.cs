using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PragimASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            ViewBag.Countries = new List<string>()
            {
                "Nigeria",
                "Ghana",
                "Niger",
                "Canada",
                "UK",
                "Netherlands"
            };

            return View();
        }

        public ActionResult GetNumbers()
        {
            ViewBag.SweetNumbers = new List<int>()
            {
                8, 13, 27, 23, 17, 25, 16, 11
            };

            return View();
        }
    }
}