using System.ComponentModel.DataAnnotations;

namespace CosmoTrek_v3.Models
{
    public class TrekPlan
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)] // todo space optimization considerations
        public string Destination { get; set; }
        public int RocketType { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool Mode { get; set; } // false is conventional propulsion

        public SpaceTravelIdentityUser SpaceTravelIdentityUser { get; set; }
        public string SpaceTravelIdentityUserId { get; set; }
    }

    public enum RocketShips
    {
        Antares, Ariane5, AstraRocket3, Ceres1, DreamChaser, Electron, Falcon9, FalconHeavy, Hyperbola1, LauncherOne, NewShepard, Soyuz2, Spica, Vega, VSSUnity
    }

}
