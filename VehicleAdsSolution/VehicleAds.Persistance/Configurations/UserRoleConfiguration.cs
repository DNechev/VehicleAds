using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VehicleAds.Domain.Entities.Users;

namespace VehicleAds.Persistance.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRoleEntity>
    {
        public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
        {
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder
                .HasOne<UserEntity>(ur => ur.User)
                .WithMany(u => u.UsersRoles)
                .HasForeignKey(ur => ur.UserId);

            builder.
                HasOne<RoleEntity>(ur => ur.Role)
                .WithMany(r => r.UsersRoles)
                .HasForeignKey(ur => ur.RoleId);

        }
    }
}
