using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Models;

namespace DBWorks.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployees()
        {
            AccessDB employeeAccessDb = new AccessDB();
            List<Employee> employees = employeeAccessDb.Employees.ToList();
            return View(employees);
        }
    }
}