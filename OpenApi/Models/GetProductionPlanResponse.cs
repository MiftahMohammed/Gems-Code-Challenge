namespace OpenApi.Models
{
    public class GetProductionPlanResponse
    {
        public GetProductionPlanResponse()
        {
            PlantPlans = new List<PlantPlan>();
        }
        public List<PlantPlan> PlantPlans { get; set; }
    }
}
