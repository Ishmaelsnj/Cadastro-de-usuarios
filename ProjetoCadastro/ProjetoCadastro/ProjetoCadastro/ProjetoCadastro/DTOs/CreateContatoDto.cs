using DocumentValidator;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.DTOs
{
    public class CreateContatoDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder {1} caracteres.")]
        public string Nome { get; set; }

        [CustomValidationCpf(ErrorMessage = "CPF inválido!!")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [MaxLength(14, ErrorMessage = "O CPF deve ter {1} caracteres.")]
        public string CPF { get; set; }

        public List<CreateTelefoneDto> Telefones { get; set; }
    }

    public class CustomValidationCpf : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is not string)
            {
                return new ValidationResult("CPF inválido!!");
            }

            if (!CpfValidation.Validate(value as string))
            {
                return new ValidationResult("CPF inválido!!");
            }
            return ValidationResult.Success;

        }
    }
}
