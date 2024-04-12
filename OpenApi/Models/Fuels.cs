using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenApi.Models
{
    public class Fuels
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price should be positive")]
        [JsonPropertyName("gas(euro/MWh)")]
        public double Gas { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price should be positive")]
        [JsonPropertyName("kerosine(euro/MWh)")]
        public double Kerosine { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price should be positive")]
        [JsonPropertyName("co2(euro/ton)")]
        public double Co2 { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Price should be positive")]
        [JsonPropertyName("wind(%)")]

        public double WindPercent { get; set; }
    }
}
