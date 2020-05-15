using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreCars.Services;

namespace AspNetCoreCars.Controllers
{
      public class CarsController : Controller
        {
        private readonly ICarsModelService _CarsModelService;
        public CarsController(ICarsModelService CarsModelService)
        {
            _CarsModelService = CarsModelService;
        }
        public async Task<IActionResult> Index()
            {
            // Get to-do items from database
            var items = await _CarModelService.GetNewModelAsync();
            // Put items into a model
            var model = new CarsViewModel()
            {
                Models = Models
            };
            // Render view using the model
            return View(model);
        }
        }
    }
