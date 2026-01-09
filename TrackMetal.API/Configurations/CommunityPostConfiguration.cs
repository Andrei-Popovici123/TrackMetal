using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class CommunityPostConfiguration : IEntityTypeConfiguration<CommunityPost>
{
    public void Configure(EntityTypeBuilder<CommunityPost> builder)
    {
        builder.ToTable("CommunityPosts")
            .HasKey(c => c.CommunityPostId);
        
        builder.Property(c => c.UserId)
            .IsRequired();
        
        builder.Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(256);
        
        builder.Property(c => c.Content)
            .IsRequired()
            .HasColumnType("text")
            .HasMaxLength(4096);
        
        builder.Property(c => c.TimeStamp)
            .IsRequired();
    }
}