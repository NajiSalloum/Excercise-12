namespace MVCGarage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_name : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Vehicles", newName: "ParkedVehicles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ParkedVehicles", newName: "Vehicles");
        }
    }
}
