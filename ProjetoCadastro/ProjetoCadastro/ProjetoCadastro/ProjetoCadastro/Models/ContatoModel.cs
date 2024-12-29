using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O nome n�o pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF � obrigat�rio.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter 14 caracteres.")]
        public string CPF { get; set; }

        // Lista de telefones associados ao contato
        public List<TelefoneModel> Telefones { get; set; } = new List<TelefoneModel>();
    }
}
