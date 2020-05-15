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
        public DateTimeOffset? CarModel { get; set; }
    }
}