using AppLocaCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppLocaCar.Infra.Data.EntityConfigurations
{
    public class CarRentDaysConfiguration : IEntityTypeConfiguration<CarRentDays>
    {
        public void Configure(EntityTypeBuilder<CarRentDays> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.CarId).IsRequired();
            builder.Property(p => p.RentDate).IsRequired();

        }
    }
}
