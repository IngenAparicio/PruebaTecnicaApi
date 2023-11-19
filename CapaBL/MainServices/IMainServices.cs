using CapaDA.Dtos;
using CapaDA.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBL.MainServices
{
    public interface IMainServices
    {
        public ResponseQuery<PersonasDto> ObtenerPersona(PersonasDto request, ResponseQuery<PersonasDto> response);

        public ResponseQuery<List<ConsultaPersonasDto>> ListaConsultaPersonas(ResponseQuery<List<ConsultaPersonasDto>> response);

        public ResponseQuery<PersonasDto> CrearPersona(PersonasDto request, ResponseQuery<PersonasDto> response);

        public ResponseQuery<PersonasDto> EditarPersona(PersonasDto request, ResponseQuery<PersonasDto> response);

        public ResponseQuery<PersonasDto> EliminarPersona(PersonasDto request, ResponseQuery<PersonasDto> response);

        public ResponseQuery<UsuarioDto> CrearUsuario(UsuarioDto request, ResponseQuery<UsuarioDto> response);

        public ResponseQuery<UsuarioDto> Login(UsuarioDto request, ResponseQuery<UsuarioDto> response);
    }
}
