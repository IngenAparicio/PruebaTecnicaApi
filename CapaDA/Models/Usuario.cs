using System;
using System.Collections.Generic;

#nullable disable

namespace CapaDA.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string UsuarioPlat { get; set; }
        public string Pass { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
