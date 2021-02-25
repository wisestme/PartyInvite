using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DBWorks.Models
{
    public class AccessDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}