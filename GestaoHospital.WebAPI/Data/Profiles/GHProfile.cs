using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Models.Usuario;

namespace GestaoHospital.WebAPI.Data.Profiles
{
    public class GHProfile : Profile
    {
        public GHProfile()
        {
            CreateMap<EntityPaciente, PacienteDto>().ReverseMap();
            CreateMap<EntityObservacao, ObservacaoDto>().ReverseMap();
            CreateMap<EntityAnotacao, AnotacaoDto>().ReverseMap();
            CreateMap<EntityCaracteristicaDieta, CaracteristicaDietaDto>().ReverseMap();
            CreateMap<EntityMapa, MapaDto>().ReverseMap();
            CreateMap<EntityPerfil, PerfilDto>().ReverseMap();
            CreateMap<EntityModulo, ModuloDto>().ReverseMap();
            CreateMap<EntityPerfilModulo, ModuloDto>().ReverseMap();
            CreateMap<EntityUsuario, GetUsuarioDto>();
            CreateMap<PostUsuarioDto, EntityUsuario>();
        }
    }
}
