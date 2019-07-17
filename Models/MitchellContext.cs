using Microsoft.EntityFrameworkCore;

namespace MitchellVehicleSolution.Models
{
    public class MitchellContext : DbContext
    {
        public MitchellContext(DbContextOptions<MitchellContext> options)
            : base(options)
        {
        }

        public DbSet<MitchellVehicleSolution.Models.Vehicle> Vehicle { get; set; }
    }
}
