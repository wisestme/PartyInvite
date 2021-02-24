using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PragimASP.Models;

namespace PragimASP.Controllers
{
    public class ApplianceController : Controller
    {
        // GET: Appliance
        public ActionResult Index()
        {
            ApplianceContext applianceContext = new ApplianceContext();
            List<Appliance> appliances = applianceContext.Appliances.ToList();
            return View();
        }
    }
}