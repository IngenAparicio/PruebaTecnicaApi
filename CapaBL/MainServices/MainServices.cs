using CapaDA.Dtos;
using CapaDA.MainDataAccess;
using CapaDA.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBL.MainServices
{
    public class MainServices : IMainServices
    {
        private readonly IMainDataAccess mainDataAccess;
        public MainServices(IMainDataAccess _mainDataAccess)
        {
            mainDataAccess = _mainDataAccess;
        }

        public ResponseQuery<PersonasDto> ObtenerPersona(PersonasDto request, ResponseQuery<PersonasDto> response)
        {
            try
            {
                response.Result = mainDataAccess.ObtenerPersona(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new PersonasDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<ConsultaPersonasDto>> ListaConsultaPersonas(ResponseQuery<List<ConsultaPersonasDto>> response)
        {
            try
            {
                response.Result = mainDataAccess.ListaConsultaPersonas();
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<ConsultaPersonasDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<PersonasDto> CrearPersona(PersonasDto request, ResponseQuery<PersonasDto> response)
        {
            try
            {
                response.Result = mainDataAccess.CrearPersona(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new PersonasDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<PersonasDto> EditarPersona(PersonasDto request, ResponseQuery<PersonasDto> response)
        {
            try
            {
                response.Result = mainDataAccess.EditarPersona(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new PersonasDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<PersonasDto> EliminarPersona(PersonasDto request, ResponseQuery<PersonasDto> response)
        {
            try
            {
                response.Result = mainDataAccess.EliminarPersona(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new PersonasDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<UsuarioDto> CrearUsuario(UsuarioDto request, ResponseQuery<UsuarioDto> response)
        {
            try
            {
                response.Result = mainDataAccess.CrearUsuario(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new UsuarioDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<UsuarioDto> Login(UsuarioDto request, ResponseQuery<UsuarioDto> response)
        {
            try
            {
                response.Result = mainDataAccess.Login(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new UsuarioDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

    }
}
