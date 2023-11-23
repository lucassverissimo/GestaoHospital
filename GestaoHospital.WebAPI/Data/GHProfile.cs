using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;

namespace GestaoHospital.WebAPI.Data
{
    public class GHProfile : Profile
    {
        public GHProfile()
        {
            CreateMap<Paciente,PacienteDto>().ReverseMap();
            CreateMap<Observacao,ObservacaoDto>().ReverseMap();
            CreateMap<Anotacao,AnotacaoDto>().ReverseMap();
            CreateMap<CaracteristicaDieta,CaracteristicaDietaDto>().ReverseMap();
            CreateMap<Mapa, MapaDto>().ReverseMap();
        }
    }
}