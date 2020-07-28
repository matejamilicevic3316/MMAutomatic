using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class FeatureConfiguration : BaseConfiguration<Feature>
    {
        public override void Configure(EntityTypeBuilder<Feature> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.AdFeatureValues)
                .WithOne(x => x.Feature)
                .HasForeignKey(x => x.IdFeature)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
