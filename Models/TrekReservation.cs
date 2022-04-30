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
        [MaxLength(5)]
        public int Zip { get; set; }

        public SpaceTravelIdentityUser SpaceTravelIdentityUser { get; set; }
        public string SpaceTravelIdentityUserId { get; set; }

    }
}
