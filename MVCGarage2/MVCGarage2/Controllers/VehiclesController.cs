using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCGarage2.DataAccessLayer;
using MVCGarage2.Models;

namespace MVCGarage2.Controllers
{
    public class VehiclesController : Controller
    {
        private StorageContext db = new StorageContext();

        // GET: Vehicles
        public ActionResult Overview(VehicleType? VehicleOfType, Color? Color, FuelType? FuelType, string Regnr = "", string Brand = "")
        {
            List<VehicleOverview> vehicles = new List<VehicleOverview>();
            foreach (var v in db.Vehicles.Where(v => (Regnr == "" || v.Regnr.Contains(Regnr)) &&
                                                     (VehicleOfType == null || v.Type == VehicleOfType.ToString()) &&
                                                     (Color == null || v.Color==Color.ToString()) &&
                                                     (FuelType==null || v.FuelType==FuelType.ToString()) &&
                                                     (Brand.Trim()=="" || v.Brand.Contains(Brand.Trim()))).ToList()) 
            {
                vehicles.Add(new VehicleOverview(v.Id, v.Regnr, v.Type, v.Color, v.ParkedTime));
            }
            return View(vehicles);
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Register()
        {
            return View(new VehicleRegister());
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park(string Regnr, VehicleType VehicleOfType, Color Color, string Brand, int NrofWheels, double Length, FuelType FuelType)
        {
            if (db.Vehicles.Any(v => v.Regnr == Regnr))
            {
                return RedirectToAction("Register");
            }

            Vehicle vehicle = new Vehicle()
            {
                Regnr = Regnr,
                Type = VehicleOfType.ToString(),
                Color = Color.ToString(),
                Brand = Brand,
                NrofWheels = NrofWheels,
                Length = Length,
                FuelType = FuelType.ToString(),
                ParkedTime = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Search()
        {
            return View(new VehicleSearch());
        }

        //// GET: Vehicles/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Vehicle vehicle = db.Vehicles.Find(id);
        //    if (vehicle == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(vehicle);
        //}

        //// POST: Vehicles/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Regnr,Type,Color,Brand,NrofWheels,Length,FuelType,ParkedTime")] Vehicle vehicle)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(vehicle).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Overview");
        //    }
        //    return View(vehicle);
        //}

        // GET: Vehicles/Delete/5
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Overview");
                //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle v = db.Vehicles.Find(id);
            VehicleCheckOut vehicle = new VehicleCheckOut(v.Id, v.Regnr, v.ParkedTime, DateTime.Now);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Receipt(int id)
        {
            Vehicle v = db.Vehicles.Find(id);
            db.Vehicles.Remove(v);
            db.SaveChanges();

            VehicleReceipt info = new VehicleReceipt(v.Id, v.Regnr, v.ParkedTime, DateTime.Now);
            return View(info);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
