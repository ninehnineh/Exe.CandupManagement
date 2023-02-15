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
    public class AppRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.ToTable("AppRoles");

            builder.Property(x => x.Description).HasMaxLength(200);

            builder.HasData(
                new ApplicationRole
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new ApplicationRole
                {
                    Id = Guid.NewGuid(),
                    Name = "Staff",
                    NormalizedName = "STAFF"
                },

                new ApplicationRole
                {
                    Id = Guid.NewGuid(),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
                );
        }
    }
}
