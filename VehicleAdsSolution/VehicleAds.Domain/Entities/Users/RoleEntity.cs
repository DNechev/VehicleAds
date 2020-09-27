using System.Collections.Generic;
using VehicleAds.Domain.Enums;

namespace VehicleAds.Domain.Entities.Users
{
    public class RoleEntity : BaseEntity
    {
        public RoleEntity()
        {
            UsersRoles = new List<UserRoleEntity>();
        }

        public int Id { get; set; }

        public Role Role { get; set; }

        public ICollection<UserRoleEntity> UsersRoles { get; set; }
    }
}
