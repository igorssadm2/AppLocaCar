using AppLocaCar.Application.Dto.Address;
using AppLocaCar.Domain.Entities.Enums;
using AppLocaCar.Helpers.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Application.Dto.User
{
    public class UserEmployeeLoginViewModel
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Pass { get; set; }

     
    }
}
