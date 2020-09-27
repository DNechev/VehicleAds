using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleAds.Domain.Entities;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.AdsWatchlist;
using VehicleAds.Domain.Entities.Features;
using VehicleAds.Domain.Entities.Regions;
using VehicleAds.Domain.Entities.Users;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Entities.VehicleDescriptions;
using VehicleAds.Domain.Entities.Vehicles;
using VehicleAds.Domain.Entities.Watchlists;

namespace VehicleAds.Persistance
{
    public class VehicleAdsDbContext : DbContext
    {
        public VehicleAdsDbContext(DbContextOptions<VehicleAdsDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<RoleEntity> Roles { get; set; }

        public DbSet<SellerEntity> Sellers { get; set; }

        public DbSet<UserRoleEntity> UsersRoles { get; set; }

        public DbSet<RegionEntity> Regions { get; set; }

        public DbSet<AdEntity> Ads { get; set; }

        public DbSet<WatchlistEntity> Watchlists { get; set; }

        public DbSet<AdWatchlistEntity> AdsWatchlists { get; set; }

        public DbSet<FeatureEntity> Features { get; set; }

        public DbSet<VehicleDescriptionEntity> VehicleDescriptions { get; set; }

        public DbSet<VehicleDescriptionFeatureEntity> VehicleDescriptionsFeatures { get; set; }

        public DbSet<VehicleEntity> Vehicles { get; set; }

        public DbSet<AutomobileEntity> Automobiles { get; set; }

        public DbSet<MotorcycleEntity> Motorcycles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VehicleAdsDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var createdEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();

            createdEntities.ForEach(e =>
            {
                var now = DateTime.UtcNow;
                e.Property(nameof(BaseEntity.CreationDate)).CurrentValue = now;
                e.Property(nameof(BaseEntity.UpdateDate)).CurrentValue = now;
            });

            var editedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();

            editedEntities.ForEach(e =>
            {
                e.Property(nameof(BaseEntity.UpdateDate)).CurrentValue = DateTime.UtcNow;
            });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
