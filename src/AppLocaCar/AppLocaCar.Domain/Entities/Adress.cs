using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Domain.Entities
{
    public class Adress
    {

        public int EnderecoId { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser Cliente { get; set; }
        public string Alias { get; set; }
        public string CEP { get; set; }
        public string PublicPlace { get; set; }

        public string Complement { get; set; }

        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Primario { get; set; }
    }
}
