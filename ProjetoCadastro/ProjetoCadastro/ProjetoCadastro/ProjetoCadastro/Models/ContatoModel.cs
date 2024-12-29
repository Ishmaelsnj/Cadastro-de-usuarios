using ProjetoCadastro.DTOs;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder {1} caracteres.")]
        public string Nome { get; set; }

        [CustomValidationCpf(ErrorMessage = "CPF inválido!!")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [MaxLength(14, ErrorMessage = "O CPF deve ter {1} caracteres.")]
        public string CPF { get; set; }

        public List<TelefoneModel> Telefones { get; set; } = new List<TelefoneModel>();
    }

}
