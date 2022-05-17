using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Core.DTOs
{
    public class PersonaDto
    {
        public int IdPersona { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
