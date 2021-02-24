using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PragimASP.Models;

namespace PragimASP.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult GetCars()
        {
            CarContext carContext = new CarContext();
            List<Car> cars = carContext.Cars.ToList();
            return View(cars);
        }
    }
}