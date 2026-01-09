namespace TrackMetal.API.Models
{
    public class LapTime
    {
        public int LapTimeId { get; set; }
        public int UserId { get; set; }
        public int LapTimeInSeconds { get; set; }
        public int Sector1TimeInSeconds { get; set; }
        public int Sector2TimeInSeconds { get; set; }
        public int Sector3TimeInSeconds { get; set; }
        public int TrackId { get; set; }
        public virtual Track Track { get; set; } = null!;
    }
}
