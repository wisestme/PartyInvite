using System.Collections.Generic;
using DBWorks.Entities;
using DBWorks.IdentityEntities;

namespace DBWorks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            //AccessDB context = new AccessDB();

            //var departments = new List<Department>
            //{
            //    new Department() {Name = "IT"},
            //    new Department() {Name = "HR"},
            //    new Department() {Name = "Admin"},
            //    new Department() {Name = "Finance"}
            //};

            //context.Departments.AddRange(departments);
            //context.SaveChanges();

        }
        
        public override void Down()
        {
        }
    }
}
