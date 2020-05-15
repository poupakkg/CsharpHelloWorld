using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreCars.Models;

namespace AspNetCoreCars.Services
{
    public interface ICarsModelService
    {
        Task<CarsModel[]> GetNewModelsAsync();
    }
}