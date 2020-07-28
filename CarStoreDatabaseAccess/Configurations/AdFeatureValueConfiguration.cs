using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class AdFeatureValueConfiguration : IEntityTypeConfiguration<AdFeatureValue>
    {
        public void Configure(EntityTypeBuilder<AdFeatureValue> builder)
        {
            builder.HasKey(x => new { x.IdAd, x.IdFeature });
            builder.HasOne(x => x.Ad)
                .WithMany(x => x.AdFeatureValues)
                .HasForeignKey(x => x.IdAd);
            builder.HasOne(x => x.Feature)
                .WithMany(x => x.AdFeatureValues)
                .HasForeignKey(x => x.IdFeature);
        }
    }
}
