using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMetal.API.Models;

namespace TrackMetal.API.Configurations;

public class SetupConfiguration: IEntityTypeConfiguration<Setup>
{
    public void Configure(EntityTypeBuilder<Setup> builder)
    {
        builder.ToTable("Setups")
            .HasKey(s => s.SetupId);

        builder.Property(s=>s.FuelLoad)
            .IsRequired();
        
        builder.Property(s=>s.TireId)
            .IsRequired();
        
        builder.Property(s=>s.Suspension)
            .IsRequired();

        builder.Property(s=>s.Aero)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.HasOne(s => s.Track)
            .WithMany(t => t.Setups)
            .HasForeignKey(s => s.TrackId)
            .HasConstraintName("FK_Track_Setup");
        
        builder.HasOne(s=>s.Car)
            .WithMany(c=>c.Setups)
            .HasForeignKey(c => c.CarId)
            .HasConstraintName("FK_Car_Setup");
    }
}