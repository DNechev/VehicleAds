using System.Collections.Generic;
using VehicleAds.Domain.Entities.Ads;

namespace VehicleAds.Domain.Entities.Regions
{
    public class RegionEntity : BaseEntity
    {
        public RegionEntity()
        {
            Ads = new List<AdEntity>();
        }

        public int Id { get; set; }

        public string Area { get; set; }

        public string PopulatedPlace { get; set; }

        public string PostalCode { get; set; }

        public ICollection<AdEntity> Ads { get; set; }
    }
}
