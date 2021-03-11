using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBWorks.Entities;
using DBWorks.IdentityEntities;
using DBWorks.Services;

namespace DBWorks.Repository
{
    public class DepartmentService : IDepartmentService
    {
        //private readonly AccessDB _accessDb;
        AccessDB accessDb = new AccessDB();
        //public DepartmentService(AccessDB accessDb)
        //{
        //    _accessDb = accessDb;
        //}
        public IEnumerable<Department> AllDepartments()
        {
            return accessDb.Departments.ToList();
            
        }
    }
}