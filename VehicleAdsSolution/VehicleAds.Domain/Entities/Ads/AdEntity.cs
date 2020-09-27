using System;
using System.Collections.Generic;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Regions;
using VehicleAds.Domain.Entities.Users;
using VehicleAds.Domain.Entities.VehicleDescriptions;

namespace VehicleAds.Domain.Entities.Ads
{
    public class AdEntity : BaseEntity
    {
        public AdEntity()
        {
            AdsWatchlists = new List<AdWatchlistEntity>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PhoneNumber { get; set; }

        public string Adress { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool Premium { get; set; }

        public int RegionId { get; set; }

        public RegionEntity Region { get; set; }

        public int SellerId { get; set; }

        public SellerEntity Seller { get; set; }

        public VehicleDescriptionEntity VehicleDescription { get; set; }

        public ICollection<AdWatchlistEntity> AdsWatchlists { get; set; }
    }
}
