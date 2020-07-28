using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class AdConfiguration : BaseConfiguration<Ad>
    {
        public override void Configure(EntityTypeBuilder<Ad> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.User)
                .WithMany(x => x.Ads)
                .HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.Vehicle)
                .WithMany(x => x.Ads)
                .HasForeignKey(x => x.VehicleId);
            builder.HasMany(x => x.AdFeatureValues)
                .WithOne(x => x.Ad)
                .HasForeignKey(x => x.IdAd)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
