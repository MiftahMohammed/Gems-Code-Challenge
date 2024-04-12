namespace OpenApi.Models
{
    public class PlantPlan
    {
        public PlantPlan(string name, double power)
        {
            Name = name;
            Power = power;
        }
        public string Name { get; set; }
        public double Power { get; set; }
    }
}
