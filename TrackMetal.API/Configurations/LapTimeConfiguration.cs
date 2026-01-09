using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class LapTimeConfiguration : IEntityTypeConfiguration<LapTime>
{
    public void Configure(EntityTypeBuilder<LapTime> builder)
    {
        builder.ToTable("LapTimes")
            .HasKey(l => l.LapTimeId);
        
        builder.Property(l => l.LapTimeInSeconds)
            .IsRequired();
        
        builder.Property(l => l.Sector1TimeInSeconds)
            .IsRequired();
        
        builder.Property(l => l.Sector2TimeInSeconds)
            .IsRequired();
        
        builder.Property(l => l.Sector3TimeInSeconds)
            .IsRequired();
        
        builder.HasOne(l => l.Track)
            .WithMany(t => t.LapTimes)
            .HasForeignKey(l => l.TrackId)
            .HasConstraintName("FK_Track_LapTime");
    }
}