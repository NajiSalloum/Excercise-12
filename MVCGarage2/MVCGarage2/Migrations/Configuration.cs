namespace MVCGarage2.Migrations
{
    using MVCGarage2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCGarage2.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCGarage2.DataAccessLayer.StorageContext context)
        {
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr="ABC123",
                Type="Car",
                Color="Red",
                Brand="Nexus",
                NrofWheels=4,
                Length=3.1,
                FuelType="Bensin",
                ParkedTime= DateTime.Now
             });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "SED234",
                Type = "BUS",
                Color = "Green",
                Brand = "Scania",
                NrofWheels = 6,
                Length = 12.7,
                FuelType = "Diesel",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "JKL456",
                Type = "Bike",
                Color = "Black",
                Brand = "Honda",
                NrofWheels = 2,
                Length = 4.1,
                FuelType = "Biogas",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "DEF567",
                Type = "Bicycle",
                Color = "Silver",
                Brand = "Btwin",
                NrofWheels = 2,
                Length = 3.12,
                FuelType = "Ethenol",
                ParkedTime = DateTime.Now
            });
        }
    }
}
