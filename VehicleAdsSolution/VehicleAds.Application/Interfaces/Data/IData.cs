using System.Threading.Tasks;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Features;
using VehicleAds.Domain.Entities.Regions;
using VehicleAds.Domain.Entities.Users;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Entities.VehicleDescriptions;
using VehicleAds.Domain.Entities.Vehicles;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Application.Interfaces.Data
{
    public interface IData
    {
        IAsyncRepository<AdEntity> Ads { get; }

        IAsyncRepository<WatchlistEntity> Watchlists { get; }

        IAsyncRepository<AdWatchlistEntity> AdsWatchlists { get; }

        IAsyncRepository<FeatureEntity> Features { get; }

        IAsyncRepository<VehicleDescriptionEntity> VehicleDescriptions { get; }

        IAsyncRepository<VehicleDescriptionFeatureEntity> VehicleDescriptionFeatures { get; }

        IAsyncRepository<UserEntity> Users { get; }

        IAsyncRepository<SellerEntity> Sellers { get; }

        IAsyncRepository<RoleEntity> Roles { get; }

        IAsyncRepository<UserRoleEntity> UserRoles { get; }

        IAsyncRepository<VehicleEntity> Vehicles { get; }

        IAsyncRepository<AutomobileEntity> Automobiles { get; }

        IAsyncRepository<MotorcycleEntity> Motorcycles { get; }

        IAsyncRepository<RegionEntity> Regions { get; }

        Task<int> SaveChangesAsync();
    }
}
