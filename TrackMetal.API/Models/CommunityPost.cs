namespace TrackMetal.API.Models
{
    public class CommunityPost
    {
        public int CommunityPostId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
