using Microsoft.EntityFrameworkCore;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.@abstract
{
    public class LogisticContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        // Definitions for use in the concrete field.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Siparis>().ToTable("Orders","dbo");
            // equalization of prop
            modelBuilder.Entity<Siparis>().Property(p => p.SiparisId).HasColumnName("OrderID");

            modelBuilder.Entity<SiparisDetay>().ToTable("OrderDetails", "Dbo");
            // equalization of prop
            modelBuilder.Entity<SiparisDetay>().Property(p => p.SiparisId).HasColumnName("OrderID");
            modelBuilder.Entity<SiparisDetay>(p => { p.HasNoKey();});
        }
    }
}
