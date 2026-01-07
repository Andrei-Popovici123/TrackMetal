using System.ComponentModel.DataAnnotations;

namespace TrackMetal.API.Models
{
    public class Setup
    {
        public int SetupId { get; set; }
        public string Aero { get; set; } = string.Empty;
        public double FuelLoad { get; set; }
        public int TireId { get; set; }
        public int Suspension { get; set; }
        
        public virtual Track Track { get; set; } = null!;
        public int TrackId { get; set; }        
        
        public virtual Car Car { get; set; } = null!;
        public int CarId { get; set; }

    }
}
