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

        public string GetDetails()
        {
            return "This is from get details action method";
        }
    }
}