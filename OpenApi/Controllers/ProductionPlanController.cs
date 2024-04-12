using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using OpenApi.Contracts;
using OpenApi.Helpers;
using OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpenApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionPlanController : ControllerBase
    {
        private readonly ILogger<ProductionPlanController> _logger;
        private readonly IEnergyPlantService _energyPlantService;

        public ProductionPlanController(ILogger<ProductionPlanController> logger, IEnergyPlantService energyPlantService)
        {
            _logger = logger;
            _energyPlantService = energyPlantService;
        }

        [HttpPost]
        public async Task<GetProductionPlanResponse> GetProductionPlan(GetProductionPlanRequest request)
        {
            try
            {
                var plantOutputPowers = _energyPlantService.GetProductionPlan(request);
                return await Task.FromResult(MapToResult(plantOutputPowers));
            }
            catch (Exception)
            {
                throw new Exception("An internal error has occured. please contact support service");
            }
        }

        private GetProductionPlanResponse MapToResult(List<PlantHelper> plantOutputPowers)
        {
            var rslt = new GetProductionPlanResponse();
            foreach (var item in plantOutputPowers)
            {
                rslt.PlantPlans.Add(new PlantPlan(item.Name, item.ProducedPower));
            }

            return rslt;
        }
    }
}
