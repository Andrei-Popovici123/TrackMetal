using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Setup
    {
        [Key]
        public int SetupId { get; set; }
        [Required]
        public string Type { get; set; } = string.Empty;
        public double FuelLoad { get; set; }


    }
}
