using CapaBL.MainServices;
using CapaDA.Dtos;
using CapaDA.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PruebaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        readonly IMainServices mainServices;

        public MainController(IMainServices _mainServices)
        {
            mainServices = _mainServices;
        }

        [HttpPost]
        [Route("ObtenerPersona")]
        public IActionResult ObtenerPersona(PersonasDto request)
        {
            ResponseQuery<PersonasDto> response = new ResponseQuery<PersonasDto>();
            mainServices.ObtenerPersona(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("ListaConsultaPersonas")]
        public IActionResult ListaConsultaPersonas()
        {
            ResponseQuery<List<ConsultaPersonasDto>> response = new ResponseQuery<List<ConsultaPersonasDto>>();
            mainServices.ListaConsultaPersonas(response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearPersona")]
        public IActionResult CrearPersona(PersonasDto request)
        {
            ResponseQuery<PersonasDto> response = new ResponseQuery<PersonasDto>();
            mainServices.CrearPersona(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("EditarPersona")]
        public IActionResult EditarPersona(PersonasDto request)
        {
            ResponseQuery<PersonasDto> response = new ResponseQuery<PersonasDto>();
            mainServices.EditarPersona(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("EliminarPersona")]
        public IActionResult EliminarPersona(PersonasDto request)
        {
            ResponseQuery<PersonasDto> response = new ResponseQuery<PersonasDto>();
            mainServices.EliminarPersona(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("CrearUsuario")]
        public IActionResult CrearUsuario(UsuarioDto request)
        {
            ResponseQuery<UsuarioDto> response = new ResponseQuery<UsuarioDto>();
            mainServices.CrearUsuario(request, response);
            return Ok(response.Result);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(UsuarioDto request)
        {
            ResponseQuery<UsuarioDto> response = new ResponseQuery<UsuarioDto>();
            mainServices.Login(request, response);
            return Ok(response.Result);
        }
    }
}
