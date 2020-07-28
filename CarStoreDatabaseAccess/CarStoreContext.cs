using CarStoreDatabaseAccess.Configurations;
using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess
{
    public class CarStoreContext : DbContext
    {

        public DbSet<Ad> Ads { get; set; }
        public DbSet<AdFeatureValue> AdFeatureValues { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehcileTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDb;Initial Catalog=CarStoreDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdConfiguration());
            modelBuilder.ApplyConfiguration(new AdFeatureValueConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TownConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new VehcileModelConfiguration());
            modelBuilder.ApplyConfiguration(new VehcileTypeConfiguration());
        }
    }
}
