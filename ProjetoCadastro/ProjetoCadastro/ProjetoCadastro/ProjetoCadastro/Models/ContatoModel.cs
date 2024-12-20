using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter 14 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O telefone não pode exceder 15 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        public string TelefoneTipo { get; set; }
    }
}
