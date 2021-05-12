using AppLocaCar.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AppLocaCar.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public TypeUser typeUser { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        //o ideal é separar a entidade de usuario das demais personas da aplicação
        public virtual ICollection<Address> Address { get; set; }


    }
}