using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double Length { get; set; }
        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public string CircuitType { get; set; } = string.Empty;
    }
}
