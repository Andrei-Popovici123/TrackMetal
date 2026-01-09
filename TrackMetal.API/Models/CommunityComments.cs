namespace TrackMetal.API.Models
{
    public class CommunityComments
    {
        public int CommunityCommentsId { get; set; }
        public int CommunityPostId { get; set; }
        public virtual CommunityPost CommunityPost { get; set; } = null!;
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime TimeStamp { get; set; }
    }
}
