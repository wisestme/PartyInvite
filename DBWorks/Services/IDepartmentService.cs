using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBWorks.Entities;

namespace DBWorks.Services
{
    public interface IDepartmentService
    {
        IEnumerable<Department> AllDepartments();
    }
}