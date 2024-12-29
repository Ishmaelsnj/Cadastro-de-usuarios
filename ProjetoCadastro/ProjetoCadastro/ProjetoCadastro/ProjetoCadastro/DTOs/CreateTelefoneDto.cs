using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCadastro.DTOs;

namespace ProjetoCadastro.DTOs
{
    public class CreateTelefoneDto
    {
        [Required(ErrorMessage = "O número do telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O número do telefone não pode exceder 15 caracteres.")]
        // Define o campo 'Numero' com a validação de tamanho
        public string Numero { get; set; }

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        [StringLength(10, ErrorMessage = "O tipo de telefone não pode exceder 10 caracteres.")]
        // Define o campo 'Tipo' com a validação de tamanho
        public string Tipo { get; set; } // Ex: "Fixo", "Comercial", "Pessoal", "WhatsApp"
    }
}
