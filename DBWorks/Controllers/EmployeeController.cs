using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Entities;
using DBWorks.IdentityEntities;


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

        public ActionResult EmployeeDetails(int id)
        {
            AccessDB employeeAccessDb = new AccessDB();
            Employee employee = employeeAccessDb.Employees.Single(e => e.EmployeeId == id);
            return View(employee);
        }
    }
}