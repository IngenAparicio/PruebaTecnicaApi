using CapaDA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDA.MainDataAccess
{
    public interface IMainDataAccess
    {
        public PersonasDto ObtenerPersona(PersonasDto request);

        public List<ConsultaPersonasDto> ListaConsultaPersonas();

        public PersonasDto CrearPersona(PersonasDto request);

        public PersonasDto EditarPersona(PersonasDto request);

        public PersonasDto EliminarPersona(PersonasDto request);

        public UsuarioDto CrearUsuario(UsuarioDto request);

        public UsuarioDto Login(UsuarioDto request);
    }
}
