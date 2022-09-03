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
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome")]

        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [CustomValidationCPFAttribute(ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Pass { get; set; }

        [Display(Name = "Senha")]
        [Compare("Pass", ErrorMessage = "As senhas não conferem.")]
        public string PassConfirm { get; set; }

        [Display(Name = "Tipo Usuario", Prompt ="Defina qual o tipo de usuario de sistema")]
        public TypeUser TypeUser { get; set; }
        [Display(Name = "Codigo operador", Prompt = "Caso seja operador, favor inserir o codigo")]
        public string CodeEmployee { get; set; }

        #region Address

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} pode ter no máximo{1} caracteres")]
        [Display(Name = "Alias")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Lougradoro")]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Numero")]
        public string Number { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        #endregion
    }
}
