using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class TrekPlan
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)] // todo space optimization considerations
        public string Destination { get; set; }
        [MaxLength(25)]
        public string RocketType { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool Mode { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public float Cost { get; set; }

        public SpaceTravelIdentityUser SpaceTravelIdentityUser { get; set; }
        public string SpaceTravelIdentityUserId { get; set; }
    }
}
