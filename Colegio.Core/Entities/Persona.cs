
using System;
using System.Collections.Generic;

#nullable disable

namespace Colegio.Core.Entities
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
