using AppLocaCar.Helpers.DomainObject;
using System.ComponentModel.DataAnnotations;


namespace AppLocaCar.Helpers.CustomAttributes
{
    /// <summary>
    /// Custom to validation attribute CPF
    /// </summary>
    public class CustomValidationCPFAttribute : ValidationAttribute
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public CustomValidationCPFAttribute() { }

        /// <summary>
        /// Validation
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            bool valido = CpfValueObject.ValidCPF(value.ToString());
            return valido;
        }

    }
}
