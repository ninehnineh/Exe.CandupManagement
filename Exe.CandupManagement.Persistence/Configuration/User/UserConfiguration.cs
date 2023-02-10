using Exe.CandupManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence.Configuration.User
{
    public class AppUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.ToTable("AppUsers");

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    EmailConfirmed = false,

                },

                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = "staff@gmail.com",
                    FirstName = "System",
                    LastName = "Staff",
                    UserName = "staff@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    EmailConfirmed = false,
                },

                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = "Customer@gmail.com",
                    FirstName = "System",
                    LastName = "Customer",
                    UserName = "Customer@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    EmailConfirmed = false,
                }

                );
        }
    }
}
