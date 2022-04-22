using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class SpaceTravelIdentityUser : IdentityUser
    {
        public List<TrekReservation> TrekReservations { get; set; } // one user to many TrekReservations

    }
}
