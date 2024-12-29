using ProjetoCadastro.DTOs;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O nome n�o pode exceder {1} caracteres.")]
        public string Nome { get; set; }

        [CustomValidationCpf(ErrorMessage = "CPF inv�lido!!")]
        [Required(ErrorMessage = "O CPF � obrigat�rio.")]
        [MaxLength(14, ErrorMessage = "O CPF deve ter {1} caracteres.")]
        public string CPF { get; set; }

        public List<TelefoneModel> Telefones { get; set; } = new List<TelefoneModel>();
    }

}
