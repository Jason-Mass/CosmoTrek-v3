using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class SpaceTravelIdentityUser : IdentityUser
    {
        public TrekReservation TrekReservation { get; set; }
        public List<TrekPlan> TrekPlan { get; set; }
    }
}
