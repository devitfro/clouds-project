using Microsoft.EntityFrameworkCore;
using UserPortal.Models;
using System;

namespace UserPortal.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Nickname = "Alina",
                    Status = "Online",
                    BirthDate = new DateTime(2000, 1, 1),
                    RegistrationDate = new DateTime(2026, 2, 8),
                    LastLogin = new DateTime(2026, 2, 8)
                },
                new User
                {
                    Id = 2,
                    Nickname = "Bob",
                    Status = "Offline",
                    BirthDate = new DateTime(1995, 5, 10),
                    RegistrationDate = new DateTime(2026, 1, 29),
                    LastLogin = new DateTime(2026, 2, 7)
                }
            );
        }
    }
}