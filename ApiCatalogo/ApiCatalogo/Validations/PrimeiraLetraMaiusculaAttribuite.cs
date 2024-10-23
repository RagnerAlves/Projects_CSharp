using System.ComponentModel.DataAnnotations;

namespace ApiCatalogo.Validations;

public class PrimeiraLetraMaiusculaAttribuite : ValidationAttribute

{
    protected override ValidationResult? IsValid(object? value,
        ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString())) 
        {
            return ValidationResult.Success;
        }

        var primeiraLetra = value.ToString()[0].ToString();
        if (primeiraLetra != primeiraLetra.ToUpper())
        {
            return new ValidationResult("A primeira letra deve ser maíuscula");
        }

        return ValidationResult.Success;
    }
}
