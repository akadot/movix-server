using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manager>().HasData(
            new Manager {
                Id = 1,
                UserType = Domain.Enums.EUserType.Manager,
                AdminRole = true,
                IsActive = true,
                FirstName = "Admin",
                LastName = "",
                Email = "admin@admin.com",
                UserName = "admin",
                Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" //SHA-256
            }
        );
    }
}
