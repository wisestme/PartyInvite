using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using DBWorks.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DBWorks.IdentityEntities
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class AccessDB : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AccessDB() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static AccessDB Create()
        {
            return new AccessDB();
        }
    }

}