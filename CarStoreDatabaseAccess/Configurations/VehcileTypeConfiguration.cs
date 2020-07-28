using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class VehcileTypeConfiguration : BaseConfiguration<VehicleType>
    {
        public override void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.HasMany(x => x.Vehicles)
                .WithOne(x => x.VehcileType)
                .HasForeignKey(x => x.VehicleTypeId);
        }
    }
}
