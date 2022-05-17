using System;
using System.Collections.Generic;

#nullable disable

namespace Colegio.Core.Entities
{
    public partial class Materia
    {
        public int IdMateria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdPersona { get; set; }

        public virtual Profesor IdPersonaNavigation { get; set; }
    }
}
