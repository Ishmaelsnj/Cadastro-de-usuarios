using ProjetoCadastro.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCadastro.Models
{
    [Table("Telefones")]
    public class TelefoneModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O número do telefone não pode exceder 15 caracteres.")]

        public string Numero { get; set; }

        public TipoTelefoneEnum TipoTelefone { get; set; }

        public int ContatoId { get; set; }

        public ContatoModel Contato { get; set; }
    }
}
