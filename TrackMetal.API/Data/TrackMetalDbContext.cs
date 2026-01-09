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
    public DbSet<User> Users { get; set; }
    public DbSet<LapTime> LapTimes { get; set; }
    public DbSet<CommunityPost> CommunityPosts { get; set; }
    public DbSet<CommunityComments> CommunityComments { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new CarConfiguration().Configure(modelBuilder.Entity<Car>());
        new CornerConfiguration().Configure(modelBuilder.Entity<Corner>());
        new SetupConfiguration().Configure(modelBuilder.Entity<Setup>());
        new TrackConfiguration().Configure(modelBuilder.Entity<Track>());
        new CommunityCommentConfiguration().Configure(modelBuilder.Entity<CommunityComments>());
        new CommunityPostConfiguration().Configure(modelBuilder.Entity<CommunityPost>());
        new LapTimeConfiguration().Configure(modelBuilder.Entity<LapTime>());
        new UserConfiguration().Configure(modelBuilder.Entity<User>());
    }
}