namespace DBWorks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFieldsToModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "City", c => c.String());
            AddColumn("dbo.Employees", "DeptId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DeptId");
            DropColumn("dbo.Employees", "City");
        }
    }
}
