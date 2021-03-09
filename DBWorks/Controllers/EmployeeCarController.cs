using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Entities;
using DBWorks.IdentityEntities;
using DBWorks.Models;

namespace DBWorks.Controllers
{
    public class EmployeeCarController : Controller
    {
        // GET: EmployeeCar
        public ActionResult ShowEmployeeCar()
        {
            AccessDB employeeAccessDb = new AccessDB();

            List<Car> cars = employeeAccessDb.Cars.ToList();
            

            List<Employee> employees = employeeAccessDb.Employees.ToList();

            var viewModel = new RandomCarViewModel()
            {
                Employee = employees,
                Car = cars

            };
            return View(viewModel);
        }
    }
}