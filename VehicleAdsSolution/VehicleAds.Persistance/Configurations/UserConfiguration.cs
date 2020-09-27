using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAds.Domain.Entities.Users;

namespace VehicleAds.Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasOne(s => s.Seller)
                .WithOne(u => u.User)
                .HasForeignKey<SellerEntity>(s => s.UserId);
        }
    }
}
