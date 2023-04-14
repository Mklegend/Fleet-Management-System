using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adding Primary Keys for the Tables !
            modelBuilder.Entity<Booking>(b => b.HasKey(b => b.BookingId));
            modelBuilder.Entity<Customer>(c => c.HasKey(c => c.CustomerId));
            modelBuilder.Entity<Inventory>(i => i.HasKey(i => i.PartId));
            modelBuilder.Entity<Maintenance>(m => m.HasKey(m => m.MaintenanceId));
            modelBuilder.Entity<Payment>(p => p.HasKey(p => p.PaymentId));
            modelBuilder.Entity<Staff>(s => { s.HasKey(s => s.ChauffeurId); });
            modelBuilder.Entity<Vehicle>(v => { v.HasKey(v => v.VehicleId);
                v.HasOne<Staff>(v => v.Chauffeur).WithOne(s => s.Vehicle).HasForeignKey<Staff>(s => s.AssignedCarId);
            });

        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}