using AppLocaCar.Domain.Entities;
using AppLocaCar.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Infra.Data.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(p => p.EnderecoId);
            builder.Property(p => p.ApplicationUserId).HasMaxLength(100).IsRequired();
            builder.Property(p => p.City).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Alias).HasMaxLength(100).IsRequired();
            builder.Property(p => p.CEP).HasMaxLength(9).IsRequired();
            builder.Property(p => p.Complement).HasMaxLength(150).IsRequired();
            builder.Property(p => p.PublicPlace).HasMaxLength(150).IsRequired();
            builder.Property(p => p.State).HasMaxLength(150).IsRequired();


        }
    }
}
