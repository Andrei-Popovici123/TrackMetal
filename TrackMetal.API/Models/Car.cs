
namespace TrackMetal.API.Models;

public class Car
{
   public int CarId { get; set; }
   public int UserId { get; set; }

    public string Model { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Hp { get; set; }
    public string Category { get; set; } = string.Empty;
    public ICollection<Setup> Setups { get; set; } = new HashSet<Setup>();
    
}