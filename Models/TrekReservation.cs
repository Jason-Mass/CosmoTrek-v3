using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class TrekReservation
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string TravelerName { get; set; }
        [MaxLength(50)]
        public string Street { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(2)]
        public string State { get; set; }
        public short Zip { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public SpaceTravelIdentityUser SpaceTravelUser { get; set; } // logical navigation property
        public string SpaceTravelUserId { get; set; } // string is default data type of ID because that corresponds to IdentityUser class Id property
        public TrekPlan TrekPlan { get; set; }
        public int TrekPlanId { get; set; }


    }
}
