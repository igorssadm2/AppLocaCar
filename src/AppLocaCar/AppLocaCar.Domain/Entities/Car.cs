using AppLocaCar.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Domain.Entities
{
    public class Car
    {
        public Car()
        {
            this.RentDays = new HashSet<CarRentDays>();
            this.inUse = true;
        }

        public int Id { get; set; }
        public bool inUse { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public GearType GearType { get; set; }
        public decimal PricePerDay { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<CarRentDays> RentDays { get; set; }
    }
}
