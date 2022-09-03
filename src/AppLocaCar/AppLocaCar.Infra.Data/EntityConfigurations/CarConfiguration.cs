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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.inUse);
            builder.Property(p => p.Model).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Year).IsRequired();
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.GearType).IsRequired();
            builder.Property(p => p.PricePerDay).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.LocationId).IsRequired();

            //config foreign Key
            builder.HasMany(x => x.RentDays).
            WithOne(x => x.Car).
            HasForeignKey(k => k.CarId);


            #region insert values in table case is empty

            builder.HasData(new Car
            {
                Id = 1,
                Model = "Mazda 6",
                Description = "The 2019 Mazda 6 doesn’t make a bad step. This year, the mid-size sedan returns mostly unchanged from last year’s version, albeit with standard safety hardware that was optional last year.",
                GearType = GearType.Automatic,
                LocationId = 1,
                PricePerDay = 65,
                Image = "https://res.cloudinary.com/dis59vn8s/image/upload/v1561808448/Mazda%206.jpg",
                Year = 2018
            });

            builder.HasData(new Car
            {
                Id = 2,
                Model = "Mazda 3",
                Description = "The Mazda 3 is a family hatch, not an SUV or a crossover or pretending to be something it’s not. These days you don’t go to the expense of creating a whole new platform from the ground up without doing more than one thing with it, though, so expect more to come from the 3’s box of bits.",
                GearType = GearType.Manual,
                LocationId = 1,
                PricePerDay = 39,
                Image = "https://res.cloudinary.com/dis59vn8s/image/upload/v1561808495/Mazda%203.jpg",
                Year = 2019
            });

            builder.HasData(new Car
            {
                Id = 3,
                Model = "BMW X7",
                Description = "The X7 by contrast is about luxury. It takes themes from the facelifted 7 Series and the 8er, to make BMW’s three-flagship fleet. They want us to see this top-end trio as a separate high-end luxury series.",
                GearType = GearType.Automatic,
                LocationId = 2,
                PricePerDay = 80,
                Image = "https://res.cloudinary.com/dis59vn8s/image/upload/v1561834504/BMW%20X7.webp",
                Year = 2019
            });


            #endregion

        }
    }
}
