using AppLocaCar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppLocaCar.Infra.Data.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CarId).IsRequired();
            builder.Property(p => p.ApplicationUserId).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10,2).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.PickUpLocationId).IsRequired();
            builder.Property(p => p.CreatedOn).IsRequired();

        }
    }
}
