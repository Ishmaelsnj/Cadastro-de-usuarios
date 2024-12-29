using AutoMapper;
using ProjetoCadastro.Models;
using ProjetoCadastro.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro.Profiles
{
    public class TelefoneProfile : Profile
    {
        public TelefoneProfile()
        {
            CreateMap<CreateTelefoneDto, TelefoneModel>();
        }
    }
}
