namespace DBWorks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePropertyType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "ExperienceYears", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "ExperienceYears", c => c.String());
        }
    }
}
