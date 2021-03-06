using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Entities;
using DBWorks.IdentityEntities;
using DBWorks.Repository;

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

        public ActionResult AddCar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            CarService carService = new CarService();
            carService.AddCar(car);
            return View("AddCar");
        }
    }
}