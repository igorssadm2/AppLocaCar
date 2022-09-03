using AppLocaCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Infra.Data.EntityConfigurations
{

    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(x => x.Orders).
            WithOne(x => x.User).
            HasForeignKey(k => k.ApplicationUserId);


            builder.HasMany(x => x.Address).
            WithOne(x => x.User).
            HasForeignKey(k => k.ApplicationUserId);
        }
    }
}
