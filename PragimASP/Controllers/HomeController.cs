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
        public string Index(string id)
        {
            return "Just returning a simple string" + id;
        }

        public string GetDetails()
        {
            return "This is from get details action method";
        }
    }
}