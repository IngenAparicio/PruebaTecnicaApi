
using System;

namespace CapaDA.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string UsuarioPlat { get; set; }
        public string Pass { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
