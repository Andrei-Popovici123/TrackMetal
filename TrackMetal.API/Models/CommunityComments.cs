namespace TrackMetal.API.Models
{
    public class CommunityComments
    {
        public int CommunityCommentsId { get; set; }
        public int CommunityPostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
