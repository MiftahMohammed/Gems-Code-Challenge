using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OpenApi.Models
{
    public class PlantInfo
    {
        [Required]
        public string Name { get; set; }

        [EnumDataType(typeof(PlantType))]
        public PlantType Type { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Efficiency should be between 0 and 1")]
        public double Efficiency { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Min power should be positive")]
        [JsonPropertyName("pmin")]
        public double MinPower {get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Max power should be positive")]
        [JsonPropertyName("pmax")]
        public double MaxPower {get; set; }

    }
}
