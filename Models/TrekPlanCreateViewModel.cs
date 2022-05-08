using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class TrekPlanCreateViewModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)] // todo space optimization considerations
        public string Destination { get; set; }
        public int RocketType { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool Mode { get; set; }
        public string SpaceTravelIdentityUserId { get; set; }
    }
}
