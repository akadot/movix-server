using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class EntitiesConfigurator
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manager>(mn => {
            mn.HasIndex(x => x.UserName).IsUnique();
            mn.HasIndex(x => x.Email).IsUnique();
        });

        modelBuilder.Entity<Driver>(dr => {
            dr.HasIndex(x => x.UserName).IsUnique();
            dr.HasIndex(x => x.Email).IsUnique();
        });
        
        modelBuilder.Entity<Trip>(tr => {
            tr.HasOne(t => t.Vehicle)
            .WithMany(v => v.Trips)
            .HasForeignKey("VehicleID")
            .IsRequired();

            tr.HasOne(t => t.Driver)
            .WithMany(v => v.Trips)
            .HasForeignKey("DriverID")
            .IsRequired();
        });
    }
}
