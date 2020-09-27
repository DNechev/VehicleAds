using System.Collections.Generic;
using VehicleAds.Domain.Entities.Ads;
using VehicleAds.Domain.Entities.VehicleDescriptionFeatures;
using VehicleAds.Domain.Entities.Vehicles;
using VehicleAds.Domain.Enums;

namespace VehicleAds.Domain.Entities.VehicleDescriptions
{
    public class VehicleDescriptionEntity : BaseEntity
    {
        public VehicleDescriptionEntity()
        {
            VehicleDescriptionsFeatures = new List<VehicleDescriptionFeatureEntity>();
            Pictures = new List<string>();
        }
        public int Id { get; set; }

        public int YearOfProduction { get; set; }

        public int Power { get; set; }

        public int Mileage { get; set; }

        public int EngineSize { get; set; }

        public int FuelConsumption { get; set; }

        public VehicleCondition Condition { get; set; }

        public VehicleEngineType EngineType { get; set; }

        public VehicleTransmissionType TransmissionType { get; set; }

        public ICollection<string> Pictures { get; set; }

        public int AdId { get; set; }

        public AdEntity Ad { get; set; }

        public int VehicleId { get; set; }

        public VehicleEntity Vehicle { get; set; }

        public ICollection<VehicleDescriptionFeatureEntity> VehicleDescriptionsFeatures { get; set; }
    }
}
