using System.Data.Entity;
using DBWorks.Entities;

namespace DBWorks.IdentityEntities
{
    public class AccessDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}