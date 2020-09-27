using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Persistance.Configurations
{
    public class AdWatchlistConfiguration : IEntityTypeConfiguration<AdWatchlistEntity>
    {
        public void Configure(EntityTypeBuilder<AdWatchlistEntity> builder)
        {
            builder.HasKey(aw => new { aw.AdId, aw.WatchlistId });

            builder.HasOne<AdEntity>(aw => aw.Ad)
                .WithMany(a => a.AdsWatchlists)
                .HasForeignKey(aw => aw.AdId);

            builder.HasOne<WatchlistEntity>(aw => aw.Watchlist)
                .WithMany(wl => wl.AdsWatchlists)
                .HasForeignKey(aw => aw.WatchlistId);
        }
    }
}
