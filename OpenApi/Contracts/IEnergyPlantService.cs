using OpenApi.Helpers;
using OpenApi.Models;

namespace OpenApi.Contracts
{
    public interface IEnergyPlantService
    {
        public List<PlantHelper> GetProductionPlan(GetProductionPlanRequest request);
    }
}
