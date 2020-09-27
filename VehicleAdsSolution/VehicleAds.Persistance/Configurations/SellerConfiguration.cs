using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAds.Domain.Entities.Users;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Persistance.Configurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<SellerEntity>
    {
        public void Configure(EntityTypeBuilder<SellerEntity> builder)
        {
            builder.HasOne(s => s.Watchlist)
                .WithOne(wl => wl.Seller)
                .HasForeignKey<WatchlistEntity>(wl => wl.SellerId);

            builder.HasMany(s => s.Ads)
                .WithOne(a => a.Seller)
                .HasForeignKey(a => a.SellerId);
        }
    }
}
