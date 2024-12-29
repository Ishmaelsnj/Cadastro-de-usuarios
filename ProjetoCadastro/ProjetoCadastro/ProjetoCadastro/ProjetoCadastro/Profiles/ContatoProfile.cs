using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjetoCadastro.DTOs;
using ProjetoCadastro.Models;

namespace ProjetoCadastro.Profiles
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<CreateContatoDto, ContatoModel>();
        }
    }
}
