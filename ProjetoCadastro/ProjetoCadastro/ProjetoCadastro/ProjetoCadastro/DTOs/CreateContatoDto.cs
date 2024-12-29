using ProjetoCadastro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.DTOs
{
    public class CreateContatoDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter 14 caracteres.")]
        public string CPF { get; set; }

        // Lista de telefones associados ao contato
        public List<CreateTelefoneDto> Telefones { get; set; }
    }
}
