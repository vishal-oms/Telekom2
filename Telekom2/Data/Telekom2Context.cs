using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelekomBeckEnd;

namespace Telekom2.Data
{
    public class Telekom2Context : DbContext
    {
        public Telekom2Context(DbContextOptions<Telekom2Context> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            bool v = Database.EnsureCreated();
        }

        public DbSet<TelekomBeckEnd.Patient> Patient { get; set; }
        public DbSet<TelekomBeckEnd.State> State { get; set; }

        public DbSet<TelekomBeckEnd.City> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().HasData(
                new State
                {
                    ID = 1,
                    Name = "Maharashtra"
                },
                new State
                {
                    ID = 2,
                    Name = "TamilNadu"
                },
                new State
                {
                    ID = 3,
                    Name = "Karnataka"
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    ID = 1,
                    Name = "Pune",
                    StateID = 1
                },
                new City
                {
                    ID = 2,
                    Name = "Mumbai",
                    StateID = 1
                },
                new City
                {
                    ID = 3,
                    Name = "Nasik",
                    StateID = 1
                },
                new City
                {
                    ID = 4,
                    Name = "Chennai",
                    StateID = 2
                },
                new City
                {
                    ID = 5,
                    Name = "Madurai",
                    StateID = 2
                },
                new City
                {
                    ID = 6,
                    Name = "Bangaluru",
                    StateID = 3
                }
                );
        }
    }
}
