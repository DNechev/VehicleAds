using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VehicleAds.Domain.Entities.Features;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Entities.VehicleDescriptions;

namespace VehicleAds.Persistance.Configurations
{
    public class VehicleDescriptionFeatureConfiguration : IEntityTypeConfiguration<VehicleDescriptionFeatureEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleDescriptionFeatureEntity> builder)
        {
            builder.HasKey(vdf => new { vdf.VehicleDescriptionId, vdf.FeatureId });

            builder.HasOne<VehicleDescriptionEntity>(vdf => vdf.VehicleDescription)
                .WithMany(vd => vd.VehicleDescriptionsFeatures)
                .HasForeignKey(vdf => vdf.VehicleDescriptionId);

            builder.HasOne<FeatureEntity>(vdf => vdf.Feature)
                .WithMany(f => f.VehicleDescriptionsFeatures)
                .HasForeignKey(vdf => vdf.FeatureId);
        }
    }
}
