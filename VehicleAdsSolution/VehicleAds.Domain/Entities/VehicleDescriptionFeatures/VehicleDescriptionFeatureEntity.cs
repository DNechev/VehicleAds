using VehicleAds.Domain.Entities.Features;
using VehicleAds.Domain.Entities.VehicleDescriptions;

namespace VehicleAds.Domain.Entities.VehicleDescriptionFeatures
{
    public class VehicleDescriptionFeatureEntity : BaseEntity
    {
        public int VehicleDescriptionId { get; set; }

        public VehicleDescriptionEntity VehicleDescription { get; set; }

        public int FeatureId { get; set; }

        public FeatureEntity Feature { get; set; }
    }
}
