using VehicleAds.Domain.Enums;

namespace VehicleAds.Domain.Entities.Vehicles
{
    public class AutomobileEntity : VehicleEntity
    {
        public AutomobileCategory Category { get; set; }
    }
}
