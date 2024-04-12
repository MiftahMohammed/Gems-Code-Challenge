using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OpenApi.Models
{
    public class GetProductionPlanRequest
    {
        [Required]
        [Range(0, double.MaxValue)]
        public double Load { get; set; }

        public Fuels Fuels { get; set; }

        public List<PlantInfo> PowerPlants { get; set; }

    }
}
