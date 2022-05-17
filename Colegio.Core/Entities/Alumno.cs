using System;
using System.Collections.Generic;

#nullable disable

namespace Colegio.Core.Entities
{
    public partial class Alumno
    {
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
