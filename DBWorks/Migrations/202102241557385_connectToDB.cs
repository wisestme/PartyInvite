namespace DBWorks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class connectToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Name = c.String(),
                        Year = c.String(),
                    })
                .PrimaryKey(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
