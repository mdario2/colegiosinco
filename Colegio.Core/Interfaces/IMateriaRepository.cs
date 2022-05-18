using Colegio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IMateriaRepository
    {
        Task<Materia> GetMateria(int id);

        Task Insert(Materia materia);

        Task<bool> AsignarMateriaAProfesor(Materia m, Profesor profe);
    }
}
