using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Models;

namespace DBWorks.Controllers
{
    public class GetCarsController : Controller
    {
        // GET: GetCars
        public ActionResult Index()
        {
            AccessDB carAccessDb = new AccessDB();
            List<Car> cars = carAccessDb.Cars.ToList();
            return View(cars);
        }
    }
}