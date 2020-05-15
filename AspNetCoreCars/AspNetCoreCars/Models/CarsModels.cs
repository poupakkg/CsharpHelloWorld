using System;
using System.ComponentModel.DataAnnotations;
namespace AspNetCoreCars.Models
{
    public class CrasModels
    {
        public Guid Id { get; set; }
        public bool NewCars { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public int Year { get; set; }
        public int CarsPrice { get; set; }
    }
}