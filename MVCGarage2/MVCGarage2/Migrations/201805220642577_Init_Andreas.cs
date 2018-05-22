namespace MVCGarage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_Andreas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Regnr = c.String(nullable: false, maxLength: 10),
                        Type = c.String(nullable: false, maxLength: 15),
                        Color = c.String(nullable: false, maxLength: 15),
                        Brand = c.String(nullable: false, maxLength: 25),
                        NrofWheels = c.Int(nullable: false),
                        Length = c.Double(nullable: false),
                        FuelType = c.String(nullable: false, maxLength: 15),
                        ParkedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
