using System.Threading.Tasks;
using VehicleAds.Application.Interfaces.Data;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Features;
using VehicleAds.Domain.Entities.Regions;
using VehicleAds.Domain.Entities.Users;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Entities.VehicleDescriptions;
using VehicleAds.Domain.Entities.Vehicles;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Persistance.Data
{
    public class VehicleAdsData : IData
    {
        private readonly VehicleAdsDbContext _context;

        public VehicleAdsData(
            VehicleAdsDbContext context,
            IAsyncRepository<AdEntity> ads,
            IAsyncRepository<WatchlistEntity> watchlists,
            IAsyncRepository<AdWatchlistEntity> adsWatchlists,
            IAsyncRepository<FeatureEntity> features,
            IAsyncRepository<VehicleDescriptionEntity> vehicleDescriptions,
            IAsyncRepository<VehicleDescriptionFeatureEntity> vehicleDescriptionFeatures,
            IAsyncRepository<UserEntity> users,
            IAsyncRepository<SellerEntity> sellers,
            IAsyncRepository<RoleEntity> roles,
            IAsyncRepository<UserRoleEntity> userRoles,
            IAsyncRepository<VehicleEntity> vehicles,
            IAsyncRepository<AutomobileEntity> automobiles,
            IAsyncRepository<MotorcycleEntity> motorcycles,
            IAsyncRepository<RegionEntity> regions)
        {
            _context = context;
            Ads = ads;
            Watchlists = watchlists;
            AdsWatchlists = adsWatchlists;
            Features = features;
            VehicleDescriptions = vehicleDescriptions;
            VehicleDescriptionFeatures = vehicleDescriptionFeatures;
            Users = users;
            Sellers = sellers;
            Roles = roles;
            UserRoles = userRoles;
            Vehicles = vehicles;
            Automobiles = automobiles;
            Motorcycles = motorcycles;
            Regions = regions;
        }

        public IAsyncRepository<AdEntity> Ads { get; }

        public IAsyncRepository<WatchlistEntity> Watchlists { get; }

        public IAsyncRepository<AdWatchlistEntity> AdsWatchlists { get; }

        public IAsyncRepository<FeatureEntity> Features { get; }

        public IAsyncRepository<VehicleDescriptionEntity> VehicleDescriptions { get; }

        public IAsyncRepository<VehicleDescriptionFeatureEntity> VehicleDescriptionFeatures { get; }

        public IAsyncRepository<UserEntity> Users { get; }

        public IAsyncRepository<SellerEntity> Sellers { get; }

        public IAsyncRepository<RoleEntity> Roles { get; }

        public IAsyncRepository<UserRoleEntity> UserRoles { get; }

        public IAsyncRepository<VehicleEntity> Vehicles { get; }

        public IAsyncRepository<AutomobileEntity> Automobiles { get; }

        public IAsyncRepository<MotorcycleEntity> Motorcycles { get; }

        public IAsyncRepository<RegionEntity> Regions { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
