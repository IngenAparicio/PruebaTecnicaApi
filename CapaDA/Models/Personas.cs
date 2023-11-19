using System;
using System.Collections.Generic;

#nullable disable

namespace CapaDA.Models
{
    public partial class Personas
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
