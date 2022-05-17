using Colegio.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Colegio.Core.Entities
{
    public partial class Profesor
    {
        public Profesor()
        {
            Materia = new HashSet<Materia>();
        }

        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Materia> Materia { get; set; }
    }
}
