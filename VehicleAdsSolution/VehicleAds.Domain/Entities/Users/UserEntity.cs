using System.Collections.Generic;

namespace VehicleAds.Domain.Entities.Users
{
    public class UserEntity : BaseEntity
    {
        public UserEntity()
        {
            UsersRoles = new List<UserRoleEntity>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Salt { get; set; }

        public SellerEntity Seller { get; set; }

        public ICollection<UserRoleEntity> UsersRoles { get; set; }
    }
}
