using System;
using System.ComponentModel.DataAnnotations;

namespace MitchellVehicleSolution.Models
{
    public class Vehicle
    {
        public int ID { get; set; }

        [Range(1950, 2050)]
        public int Year { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }
    }
}
