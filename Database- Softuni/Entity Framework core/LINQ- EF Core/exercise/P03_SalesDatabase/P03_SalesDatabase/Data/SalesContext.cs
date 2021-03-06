﻿namespace P03_SalesDatabase.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_SalesDatabase.Data.configuration;
    using P03_SalesDatabase.Data.Models;

    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                //by default it is unicode
                entity.Property(e => e.Name)
                .IsUnicode(true);

                //by default it is unicode
                entity.Property(e => e.Email)
                .IsUnicode(true);

                entity.Property(e => e.CreditCardNumber)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
              .IsUnicode(true);

                entity.Property(e => e.Description)
                .HasDefaultValue("No description");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.Date)
                .HasDefaultValue("GETDATE()");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                //by default it is unicode
                entity.Property(e => e.Name)
                .IsUnicode(true);
            });
        }
    }
}
