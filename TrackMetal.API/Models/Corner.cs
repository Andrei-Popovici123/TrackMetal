using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Corner
    {
        [Key]
        public int CornerId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
    }
}
