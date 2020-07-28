using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.Configurations
{
    public class TownConfiguration : BaseConfiguration<Town>
    {
        public override void Configure(EntityTypeBuilder<Town> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.HasMany(x => x.Users)
                .WithOne(x => x.Town)
                .HasForeignKey(x => x.IdTown)
                .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
