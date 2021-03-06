using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBWorks.Entities;
using DBWorks.IdentityEntities;
using DBWorks.Services;

namespace DBWorks.Repository
{
    public class CarService : ICarService
    {
        public void AddCar(Car car)
        {
            AccessDB accessDB = new AccessDB();
            accessDB.Cars.Add(car);
            accessDB.SaveChanges();
        }
    }
}