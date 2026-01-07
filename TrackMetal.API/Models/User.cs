namespace TrackMetal.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public int Role { get; set; }
        public int SafetyRating { get; set; }
        public int ExperienceRating { get; set; }
    }
}
