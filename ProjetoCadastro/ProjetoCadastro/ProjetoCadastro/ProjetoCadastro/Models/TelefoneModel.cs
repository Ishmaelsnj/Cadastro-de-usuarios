using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCadastro.Models
{
    [Table("Telefones")]  // Define explicitamente o nome da tabela no banco
    public class TelefoneModel
    {
        // A propriedade 'Id' é a chave primária, então o nome da tabela 'Telefones' será associada a esta chave
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O número do telefone não pode exceder 15 caracteres.")]
        // Define o campo 'Numero' com a validação de tamanho
        public string Numero { get; set; }

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        [StringLength(10, ErrorMessage = "O tipo de telefone não pode exceder 10 caracteres.")]
        // Define o campo 'Tipo' com a validação de tamanho
        public string Tipo { get; set; } // Ex: "Fixo", "Comercial", "Pessoal", "WhatsApp"

        // Chave estrangeira para o Contato
        // Este campo vincula o telefone ao contato, sendo uma chave estrangeira
        public int ContatoId { get; set; }

        // Navegação para o Contato
        // Define que o Telefone está vinculado a um Contato
        public ContatoModel Contato { get; set; }
    }
}
