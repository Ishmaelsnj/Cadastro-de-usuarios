using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCadastro.DTOs;
using ProjetoCadastro.Enums;

namespace ProjetoCadastro.DTOs
{
    public class CreateTelefoneDto
    {
        [Required(ErrorMessage = "O número do telefone é obrigatório.")]
        [StringLength(15, ErrorMessage = "O número do telefone não pode exceder 15 caracteres.")]
        public string Numero { get; set; }
        public TipoTelefoneEnum TipoTelefone { get; set; }
    }
}
