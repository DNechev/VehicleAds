using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAds.Domain.Entities.VehicleDescriptions;

namespace VehicleAds.Persistance.Configurations
{
    public class VehicleDescriptionConfiguration : IEntityTypeConfiguration<VehicleDescriptionEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleDescriptionEntity> builder)
        {
            builder.HasOne(vd => vd.Vehicle)
                .WithMany(v => v.Descriptions)
                .HasForeignKey(vd => vd.VehicleId);
        }
    }
}
