using AutoMapper;
using CapaDA.Dtos;
using CapaDA.Models;
using CapaDA.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDA.MainDataAccess
{
    public class MainDataAccess : IMainDataAccess
    {
        protected PruebaDbContext context;
        private readonly IMapper mapper;

        public MainDataAccess(PruebaDbContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public PersonasDto ObtenerPersona(PersonasDto request)
        {
            Personas persona = new Personas();
            persona = context.Personas.FirstOrDefault(x => x.Id == request.Id);
            if (persona != null)
            {
                return mapper.Map<PersonasDto>(persona);
            }
            else
            {
                return new PersonasDto();
            }
            
        }

        public List<ConsultaPersonasDto> ListaConsultaPersonas()
        {
            StringBuilder query = new StringBuilder("exec [dbo].[ConsultaPersonas] ");
            List<ConsultaPersonas> entidad = context.ConsultaPersonas.FromSqlRaw(query.ToString()).ToList();
            if(entidad != null && entidad.Count > 0)
            {
                return mapper.Map<List<ConsultaPersonasDto>>(entidad);
            }
            else
            {
                return new List<ConsultaPersonasDto>();
            }
                
        }

        public PersonasDto CrearPersona(PersonasDto request)
        {
            var persona = mapper.Map<Personas>(request);
            context.Personas.Add(persona);
            context.SaveChanges();
            var personaResult = mapper.Map<PersonasDto>(persona);
            return personaResult;
        }

        public PersonasDto EditarPersona(PersonasDto request)
        {

            var persona = context.Personas.FirstOrDefault(x => x.Id == request.Id);
            if (persona != null)
            {
                // Campos a actualizar
                FrameworkTypeUtility.SetProperties(request, persona);

                // Guardar cambios
                context.SaveChanges();
                var personaResult = mapper.Map<PersonasDto>(request);
                return personaResult;
            }
            else
            {
                return new PersonasDto();
            }
            
            
        }

        public PersonasDto EliminarPersona(PersonasDto request)
        {

            var persona = context.Personas.FirstOrDefault(x => x.Id == request.Id);
            if (persona != null)
            {
                // Campos a actualizar                
                context.Personas.Remove(persona);

                // Guardar cambios
                context.SaveChanges();                
                return new PersonasDto();
            }
            else
            {
                return new PersonasDto();
            }

        }

        public UsuarioDto CrearUsuario(UsuarioDto request)
        {
            var usuario = mapper.Map<Usuario>(request);
            context.Usuario.Add(usuario);
            context.SaveChanges();
            var UsuarioResult = mapper.Map<UsuarioDto>(usuario);
            return UsuarioResult;
        }

        public UsuarioDto Login(UsuarioDto request)
        {
            Usuario usuario = new Usuario();
            usuario = context.Usuario.FirstOrDefault(x => x.UsuarioPlat == request.UsuarioPlat && x.Pass == request.Pass);
            if (usuario != null)
            {
                return mapper.Map<UsuarioDto>(usuario);
            }
            else
            {
                return new UsuarioDto();
            }

        }

    }
}
