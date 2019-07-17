using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MitchellVehicleSolution.Models
{
    public class VehicleMakeViewModel
    {
        public List<Vehicle> vehicles;
        public SelectList makers;
        public string vehicleMake { get; set; }
    }
}
