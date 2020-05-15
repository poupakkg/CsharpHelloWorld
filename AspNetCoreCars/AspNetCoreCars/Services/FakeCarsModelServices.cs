using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreCars.Models;
namespace AspNetCoreCars.Services
{
    public class FakeCarsModelService : ICarsModelService
    {
        public Task<CarsModel[]> GetNewCarsAsync()
        {
            var Car1 = new CarsModel
            {
                CarName = "BMW",
                Year = 2012
            };
            var Car2 = new CarsModel
            {
                CarName = "F150",
                Year = 2014
            };
            return Task.FromResult(new[] { Car1, iCar2 });
        }
    }
}