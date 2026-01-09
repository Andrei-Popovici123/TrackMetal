using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class TrackConfiguration : IEntityTypeConfiguration<Track>
{
    public void Configure(EntityTypeBuilder<Track> builder)
    {
        builder.ToTable("Tracks")
            .HasKey(t => t.TrackId);

        builder.Property(t => t.Length)
            .HasColumnType("float")
            .IsRequired();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.Country)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.CircuitType)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.LapRecord)
            .IsRequired();
    }
}