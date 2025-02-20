using lotus.ExternalServices.AdbContext.Configarations;
using lotus.models;
using Microsoft.EntityFrameworkCore;

namespace lotus.ExternalServices.AdbContext;

public class AppDbContext : DbContext
{
    //dbset
    public DbSet<User> Users { get; set; }
    public DbSet<Travelplan> Travels { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Transportation> Transportations { get; set; }
    
    
    
    //Relationship 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TravelConfiguration());
        modelBuilder.ApplyConfiguration(new DestinationConfiguration());
        modelBuilder.ApplyConfiguration(new TransportationConfiguration());
    }
}