using AppLocaCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppLocaCar.Infra.Data.EntityConfigurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();


            builder.HasData(new Location { Id = 1, Name = "Localiza ponto de locação 1" });
            builder.HasData(new Location { Id = 2, Name = "Localiza local diferente do ponto 1" });
        }
    }
}
