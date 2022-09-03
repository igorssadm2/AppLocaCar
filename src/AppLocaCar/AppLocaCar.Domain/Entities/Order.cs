using AppLocaCar.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Domain.Entities
{
    public class Order
    {

        public Order()
        {
            Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }
        public string Id { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public decimal Price { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public OrderStatus Status { get; set; }
        public int PickUpLocationId { get; set; }
        public virtual Location PickUpLocation { get; set; }
        public int ReturnLocationId { get; set; }
        public virtual Location ReturnLocation { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
