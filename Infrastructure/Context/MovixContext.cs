using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class MovixContext(DbContextOptions<MovixContext> options) : DbContext(options)
{
    public DbSet<Driver> Drivers {get; set;}
    public DbSet<Manager> Managers {get; set;}
    public DbSet<Vehicle> Vehicles {get; set;}
    public DbSet<Trip> Trips {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        EntitiesConfigurator.Configure(modelBuilder);
        DataSeeder.Seed(modelBuilder);
    }    
}
