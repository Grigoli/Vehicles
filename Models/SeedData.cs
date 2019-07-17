using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MitchellVehicleSolution.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MitchellContext(
                serviceProvider.GetRequiredService<DbContextOptions<MitchellContext>>()))
            {
                // Look for any Vehicle.
                if (context.Vehicle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Vehicle.AddRange(
                    new Vehicle
                     {
                         ID = 1,
                         Year = 2017,
                         Make = "Mercedes-Benz",
                         Model = "S-Class"
                     },

                    new Vehicle
                     {
                         ID = 2,
                         Year = 2018,
                         Make = "Bentley",
                         Model = "Bentayaga"
                     },

                    new Vehicle
                     {
                         ID = 3,
                         Year = 2015,
                         Make = "Porsche",
                         Model = "Panamera"
                     },

                    new Vehicle
                   {
                        ID = 4,
                        Year = 2016,
                        Make = "Tesla",
                        Model = "Model X"
                   },
                    new Vehicle
                    {
                        ID = 5,
                        Year = 2005,
                        Make = "BMW",
                        Model = "X5"
                    },
                    new Vehicle
                    {
                        ID = 6,
                        Year = 2018,
                        Make = "Tesla",
                        Model = "Model 3"
                    },
                    new Vehicle
                    {
                        ID = 7,
                        Year = 2017,
                        Make = "Mercedes-Benz",
                        Model = "GLC-Class"
                    },
                    new Vehicle
                    {
                        ID = 8,
                        Year = 2017,
                        Make = "Tesla",
                        Model = "Model X"
                    },
                    new Vehicle
                    {
                        ID = 9,
                        Year = 2016,
                        Make = "Mercedes-Benz",
                        Model = "GLE-Class"
                    },
                    new Vehicle
                    {
                        ID = 10,
                        Year = 2015,
                        Make = "Tesla",
                        Model = "Model X"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
