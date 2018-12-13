using CruisesWebApp.Data.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }

        public DbSet<SalesUnit> SalesUnits { get; set; }

        public DbSet<Ship> Ships { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Ship)
                .WithMany(s => s.Bookings);

            modelBuilder.Entity<Ship>()
                .HasOne(s => s.SalesUnit)
                .WithMany(su => su.Ships);

            base.OnModelCreating(modelBuilder);
        }

    }
}
