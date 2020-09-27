using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.VehicleDescriptions;

namespace VehicleAds.Persistance.Configurations
{
    public class AdConfiguration : IEntityTypeConfiguration<AdEntity>
    {
        public void Configure(EntityTypeBuilder<AdEntity> builder)
        {
            builder.HasOne(a => a.Region)
                .WithMany(r => r.Ads)
                .HasForeignKey(a => a.RegionId);

            builder.HasOne(a => a.VehicleDescription)
                .WithOne(vd => vd.Ad)
                .HasForeignKey<VehicleDescriptionEntity>(vd => vd.AdId);
        }
    }
}
