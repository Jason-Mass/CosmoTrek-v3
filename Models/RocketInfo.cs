using Newtonsoft.Json;

namespace CosmoTrek_v3.Models
{
    public static class RocketInfo
    {
        public static string[] Rocket0 = new string[] { "Antares (aka Taurus II)", "Northrup Grumman", "United States", "$85 M", "657,000", "1,656,200", "0.396691220867045", "133,490" };
        public static string[] Rocket1 = new string[] { "Ariane 5", "Arianespace", "France", "$185 M", "1,713,000", "3,534,100", "0.484706148665856", "163,108" };
        public static string[] Rocket2 = new string[] { "Astra Rocket 3", "Astra Space", "United States", "$2.5 M", "24,251", "31,473", "0.770533473135704", "259,292" };
        public static string[] Rocket3 = new string[] { "Ceres-1", "Galactic Energy", "China", "UNK", "66,138", "132,188", "0.500332859261052", "168,367" };
        public static string[] Rocket4 = new string[] { "Dream Chaser", "Sierra Nevada Corporation", "United States", "TBD", "LEO", "LEO", "LEO", "LEO" };
        public static string[] Rocket5 = new string[] { "Electron", "Rocket Lab", "United States", "$7.5 M", "28,000", "56,200", "0.498220640569395", "167,656" };
        public static string[] Rocket6 = new string[] { "Falcon 9(Block 5)", "SpaceX", "United States", "$67 M", "1,210,000", "1,910,000", "0.633507853403141", "213,182" };
        public static string[] Rocket7 = new string[] { "Falcon Heavy(w/ StarShip)", "SpaceX", "United States", "$97 M", "3,130,000", "5,310,000", "0.589453860640301", "198,357" };
        public static string[] Rocket8 = new string[] { "Hyperbola-1", "i-Space", "China", "UNK", "74,956", "92,593", "0.809519489552149", "272,411" };
        public static string[] Rocket9 = new string[] { "LauncherOne", "Virgin Orbit", "United States", "$12 M", "60,000", "78,500", "0.764331210191083", "257,205" };
        public static string[] Rocket10 = new string[] { "New Shepard ", "Blue Origin", "United States", "$250K", "165,000", "110,000", "1.50", "504,765" };
        public static string[] Rocket11 = new string[] { "Soyuz-2", "Roscosmos(via Space Adventures)", "Russia", "TBD", "312,000", "438,320", "0.711808724219748", "239,531" };
        public static string[] Rocket12 = new string[] { "Spica ", "Copenhagen Suborbitals", "Denmark", "Non-profit", "8818", "22,481", "0.392242337974289", "131,993" };
        public static string[] Rocket13 = new string[] { "Vega", "Arianespace(France)", "Italy", "$37 M", "302,000", "762,540", "0.396044797649959", "133,273" };
        public static string[] Rocket14 = new string[] { "VSS Unity(SpaceShipTwo)", "Virgin Galactic and The Spaceship Company", "United States", "$250K", "LEO", "LEO", "LEO", "LEO" };

        public static string[] GetRocket(int rocketType)
        {
            switch (rocketType)
            {
                case 0:
                    return Rocket0;
                case 1:
                    return Rocket1;
                case 2:
                    return Rocket2;
                case 3:
                    return Rocket3;
                case 4:
                    return Rocket4;
                case 5:
                    return Rocket5;
                case 6:
                    return Rocket6;
                case 7:
                    return Rocket7;
                case 8:
                    return Rocket8;
                case 9:
                    return Rocket9;
                case 10:
                    return Rocket10;
                case 11:
                    return Rocket11;
                case 12:
                    return Rocket12;
                case 13:
                    return Rocket13;
                case 14:
                    return Rocket14;
                default:
                    return null;
            }
        }
    }

    

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public float DataPoint { get; set; }
        public int Date { get; set; }
        public float AstronomicalUnits { get; set; }
        public float Kilometers { get; set; }
        public float Miles { get; set; }
    }

    public class Ephemerides
    {
        Rootobject MoonEphemeride = JsonConvert.DeserializeObject<Rootobject>(moonJson);
        Rootobject MarsEphemeride = JsonConvert.DeserializeObject<Rootobject>(marsJson);
        Rootobject VenusEphemeride = JsonConvert.DeserializeObject<Rootobject>(venusJson);

        static string moonJson = "";

        static string marsJson = "";

        static string venusJson = "";
    }

}
