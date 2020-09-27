using System.Collections.Generic;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Domain.Entities.Users
{
    public class SellerEntity : UserEntity
    {
        public SellerEntity()
        {
            Ads = new List<AdEntity>();
        }

        public int? UserId { get; set; }

        public UserEntity User { get; set; }

        public WatchlistEntity Watchlist { get; set; }

        public ICollection<AdEntity> Ads { get; set; }
    }
}
