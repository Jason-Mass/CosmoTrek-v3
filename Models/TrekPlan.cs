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

    public static class TrekPlanMisc
    {
        public static string[] RocketShips = new string[]
        {
            "Antares", "Ariane 5", "Astra Rocket 3", "Ceres-1", "Dream Chaser", "Electron", "Falcon 9", "Falcon Heavy", "Hyperbola 1", "Launcher One", "New Shepard", "Soyuz-2", "Spica", "Vega", "VSS Unity"
        };

        public static string[] PropulsionModes = new string[] { "Conventional", "Warp Drive (Lightspeed)" };
    }



}
