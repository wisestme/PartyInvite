using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBWorks.Repository;
using DBWorks.Services;

namespace DBWorks.Controllers
{
    public class DepartmentController : Controller
    {
        //private readonly DepartmentService _departmentService;
        DepartmentService departmentService = new DepartmentService();

        public DepartmentController()
        {

        }
        //public DepartmentController(IDepartmentService departmentService)
        //{
        //    departmentService = _departmentService;
        //}
        // GET: Department
        public ActionResult AllDepartments()
        {
            var departmentsList = departmentService.AllDepartments();
            
            if (departmentsList == null)
                return HttpNotFound();

            return View(departmentsList);
        }
    }
}