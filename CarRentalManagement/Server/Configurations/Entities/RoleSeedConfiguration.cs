using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
             new IdentityRole
             {
                 Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR"
             },
             new IdentityRole
             {
                 Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                 Name = "User",
                 NormalizedName = "USER"
             }
             );
        }
    }
}
