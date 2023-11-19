using AutoMapper;
using CapaDA.Dtos;
using CapaDA.Models;

namespace TurnosWebV2
{
    public class GlobalMapper : Profile
    {

        public GlobalMapper()
        {
            CreateMap<PersonasDto, Personas>().ReverseMap(); 
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
            CreateMap<ConsultaPersonasDto, ConsultaPersonas>().ReverseMap();
        }
    }
}
