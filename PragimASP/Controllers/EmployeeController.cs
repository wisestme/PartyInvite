using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PragimASP.Models;

namespace PragimASP.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "Chijioke",
                City = "Enugu",
                Gender = "Male"
            };
            return View();
        }
    }
}