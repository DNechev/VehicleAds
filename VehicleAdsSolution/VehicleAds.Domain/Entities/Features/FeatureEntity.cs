using System.Collections.Generic;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Enums;

namespace VehicleAds.Domain.Entities.Features
{
    public class FeatureEntity : BaseEntity
    {
        public FeatureEntity()
        {
            VehicleDescriptionsFeatures = new List<VehicleDescriptionFeatureEntity>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public FeatureAvailability Availability { get; set; }

        public ICollection<VehicleDescriptionFeatureEntity> VehicleDescriptionsFeatures { get; set; }
    }
}
