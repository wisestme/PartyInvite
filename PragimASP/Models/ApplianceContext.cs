using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PragimASP.Models
{
    public class ApplianceContext : DbContext
    {
        public DbSet<Appliance> Appliances { get; set; }
    }
}