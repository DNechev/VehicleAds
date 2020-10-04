using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Domain.Entities.AdsWatchlist
{
    public class AdWatchlistEntity : BaseEntity
    {
        public int AdId { get; set; }

        public AdEntity Ad { get; set; }

        public int WatchlistId { get; set; }

        public WatchlistEntity Watchlist { get; set; }
    }
}
