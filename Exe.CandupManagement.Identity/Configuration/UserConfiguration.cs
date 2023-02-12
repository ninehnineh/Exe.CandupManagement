using Exe.CandupManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Identity.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "1",
                    Email = "admin@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    EmailConfirmed = false,
                    
                },

                new ApplicationUser
                {
                    Id = "2",
                    Email = "staff@gmail.com",
                    FirstName = "System",
                    LastName = "Staff",
                    UserName = "staff@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    EmailConfirmed = false,
                },

                new ApplicationUser
                {
                    Id = "3",
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
