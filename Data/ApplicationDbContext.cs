using CosmoTrek_v3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CosmoTrek_v3.Data
{
    public class ApplicationDbContext : IdentityDbContext<SpaceTravelIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TrekPlan> TrekPlans { get; set; }
        public DbSet<TrekReservation> TrekReservations { get; set; }
    }
}