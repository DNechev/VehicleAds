using System.Collections.Generic;
using VehicleAds.Domain.Entities.VehicleDescriptions;
using VehicleAds.Domain.Enums;

namespace VehicleAds.Domain.Entities.Vehicles
{
    public class VehicleEntity : BaseEntity
    {
        public VehicleEntity()
        {
            Descriptions = new List<VehicleDescriptionEntity>();
        }
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public VehicleCategory Category { get; set; }

        public ICollection<VehicleDescriptionEntity> Descriptions { get; set; }
    }
}
