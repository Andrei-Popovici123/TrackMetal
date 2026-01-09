using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class CornerConfiguration : IEntityTypeConfiguration<Corner>
{
    public void Configure(EntityTypeBuilder<Corner> builder)
    {
        builder.ToTable("Corners")
            .HasKey(c => c.CornerId);

        builder.Property(c => c.Sector)
            .IsRequired();

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(c => c.OfficialName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Type)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasOne(c => c.Track)
            .WithMany(t => t.Corners)
            .HasForeignKey(c => c.TrackId)
            .HasConstraintName("FK_Track_Corner");
    }
}