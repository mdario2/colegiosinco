using Colegio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IMateriaRepository
    {
        Task<IEnumerable<Materia>> Get();

        Task Insert(Materia materia);

        Task<bool> AsignarMateriaAProfesor(int id, Profesor profe);
    }
}
