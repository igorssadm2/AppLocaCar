﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public virtual DateTime CreatedOn { get; set; }

        public virtual DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public virtual DateTime? DeletedOn { get; set; }
    }
}
