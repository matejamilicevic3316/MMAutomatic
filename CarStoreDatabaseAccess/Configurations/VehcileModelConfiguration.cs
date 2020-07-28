using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class VehcileModelConfiguration : BaseConfiguration<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.HasOne(x => x.VehcileType)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(x => x.VehicleTypeId);
            builder.HasMany(x => x.Ads)
                .WithOne(x => x.Vehicle)
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
