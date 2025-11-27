using Microsoft.EntityFrameworkCore;
using TrackMetal.API.Configurations;
using TrackMetal.API.Models;

namespace TrackMetal.API.Data;

public class TrackMetalDbContext : DbContext
{
    public TrackMetalDbContext(DbContextOptions<TrackMetalDbContext> options) : base(options)
    {
    }
    
    public DbSet<Car> Cars { get; set; }
    public DbSet<Setup> Setups { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Corner> Corners { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new CarConfiguration().Configure(modelBuilder.Entity<Car>());
    }
}