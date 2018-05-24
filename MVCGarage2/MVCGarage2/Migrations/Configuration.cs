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
                ParkedTime= new DateTime(1998,6,24)
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
                ParkedTime = new DateTime(2018, 5, 24)
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
                ParkedTime = new DateTime(2018, 5, 22, 8, 54, 12)
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "DEF567",
                Type = "Bike",
                Color = "Silver",
                Brand = "Btwin",
                NrofWheels = 2,
                Length = 3.12,
                FuelType = "Ethenol",
                ParkedTime = new DateTime(2018, 5, 23, 18, 54, 12)
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "FGH765",
                Type = "Car",
                Color = "Black",
                Brand = "Volvo",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = new DateTime(2018, 5, 25, 8, 54, 12)
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "TYU654",
                Type = "Car",
                Color = "Black",
                Brand = "Fiat",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "HGF472",
                Type = "Car",
                Color = "Black",
                Brand = "BMW",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "BE4RT3",
                Type = "Car",
                Color = "Black",
                Brand = "A German Car",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "TAXI4U",
                Type = "Car",
                Color = "Yellow",
                Brand = "Hackney Carriage",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "SDF654",
                Type = "Car",
                Color = "Black",
                Brand = "Volvo",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "BVC364",
                Type = "Car",
                Color = "Black",
                Brand = "Fiat",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "MVCISCRAP",
                Type = "Bus",
                Color = "Green",
                Brand = "Non of your business",
                NrofWheels = 6,
                Length = 12,
                FuelType = "Biogas",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZBC123",
                Type = "Car",
                Color = "Red",
                Brand = "Nexus",
                NrofWheels = 4,
                Length = 3.1,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZED234",
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
                Regnr = "ZKL456",
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
                Regnr = "ZEF567",
                Type = "Bike",
                Color = "Silver",
                Brand = "Btwin",
                NrofWheels = 2,
                Length = 3.12,
                FuelType = "Ethenol",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZGH765",
                Type = "Car",
                Color = "Black",
                Brand = "Volvo",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZYU654",
                Type = "Car",
                Color = "Black",
                Brand = "Fiat",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZGF472",
                Type = "Car",
                Color = "Black",
                Brand = "BMW",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZE4RT3",
                Type = "Car",
                Color = "Black",
                Brand = "A German Car",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZAXI4U",
                Type = "Car",
                Color = "Yellow",
                Brand = "Hackney Carriage",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZDF654",
                Type = "Car",
                Color = "Black",
                Brand = "Volvo",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZVC364",
                Type = "Car",
                Color = "Black",
                Brand = "Fiat",
                NrofWheels = 4,
                Length = 4,
                FuelType = "Bensin",
                ParkedTime = DateTime.Now
            });
            context.Vehicles.AddOrUpdate(v => v.Regnr, new Vehicle()
            {
                Regnr = "ZVCISCRAP",
                Type = "Bus",
                Color = "Green",
                Brand = "Non of your business",
                NrofWheels = 6,
                Length = 12,
                FuelType = "Biogas",
                ParkedTime = DateTime.Now
            });
        }
    }
}
