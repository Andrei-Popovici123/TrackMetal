using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Track
    {

        public int TrackId { get; set; }

        public string Name { get; set; } = string.Empty;

        public double Length { get; set; }

        public string Country { get; set; } = string.Empty;

        public string CircuitType { get; set; } = string.Empty;

        public int LapRecord { get; set; }

        public ICollection<Corner> Corners { get; set; } = new HashSet<Corner>();
        public ICollection<Setup> Setups { get; set; } = new HashSet<Setup>();
        public ICollection<LapTime> LapTimes { get; set; } = new List<LapTime>();


    }
}
