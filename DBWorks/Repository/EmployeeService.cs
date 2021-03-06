using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBWorks.Entities;
using DBWorks.IdentityEntities;
using DBWorks.Services;

namespace DBWorks.Repository
{
    public class EmployeeService
    {
        AccessDB _dbAccess = new AccessDB();
        public void AddEmployee(Employee employee)
        {
            _dbAccess.Employees.Add(employee);
            _dbAccess.SaveChanges();
        }
    }
}