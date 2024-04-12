using OpenApi.Models;

namespace OpenApi.Helpers
{
    public class PlantHelper
    {
        public PlantHelper(PlantInfo info, double windPerceent)
        {
            Name = info.Name;
            Type = info.Type;
            Efficiency = info.Efficiency;
            MinPower = info.MinPower;
            MaxPower = info.MaxPower;
            OutputMinPower = CalculateReelPower(windPerceent, info, MinPower);
            OutputMaxPower = CalculateReelPower(windPerceent, info, MaxPower);
        }

        public string Name { get; set; }
        public PlantType Type { get; set; }

        public double Efficiency { get; set; }

        public double MinPower { get; set; }
        public double MaxPower { get; set; }
    
        //Power produced with efficiency taken into account
        public double OutputMinPower { get; set; }
        public double OutputMaxPower { get; set; }

        public double ProducedPower { get; set; }

        private double CalculateReelPower(double windPercent, PlantInfo plantInfo, double power)
        {
            return power * (plantInfo.Type == PlantType.Windturbine ? windPercent * 0.01 : 1);
        }
    }
}
