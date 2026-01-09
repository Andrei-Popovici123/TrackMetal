using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class CommunityCommentConfiguration : IEntityTypeConfiguration<CommunityComments>
{
    public void Configure(EntityTypeBuilder<CommunityComments> builder)
    {
        builder.ToTable("CommunityComments")
            .HasKey(c => c.CommunityCommentsId);
        
        builder.Property(c => c.UserId)
            .IsRequired();
        
        builder.Property(c => c.Content)
            .IsRequired()
            .HasColumnType("text")
            .HasMaxLength(4096);
        
        builder.Property(c => c.TimeStamp)
            .IsRequired();
        
        builder.HasOne(c => c.CommunityPost)
            .WithMany(p => p.Comments)
            .HasForeignKey(c => c.CommunityPostId)
            .HasConstraintName("FK_Post_Comment");
    }
}