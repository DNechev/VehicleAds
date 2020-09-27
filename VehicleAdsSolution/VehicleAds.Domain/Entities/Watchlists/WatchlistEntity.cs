using System.Collections.Generic;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Users;

namespace VehicleAds.Domain.Entities.Watchlists
{
    public class WatchlistEntity : BaseEntity
    {
        public WatchlistEntity()
        {
            AdsWatchlists = new List<AdWatchlistEntity>();
        }

        public int Id { get; set; }

        public int SellerId { get; set; }

        public SellerEntity Seller { get; set; }

        public ICollection<AdWatchlistEntity> AdsWatchlists { get; set; }
    }
}
