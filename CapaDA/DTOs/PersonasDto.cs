
using System;

namespace CapaDA.Dtos
{
    public class PersonasDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NoIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string IdCalculada { get; set; }
        public string NombreCompleto { get; set; }
    }
}
