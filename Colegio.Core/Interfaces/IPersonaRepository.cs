using Colegio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IPersonaRepository
    {
        //Task<IEnumerable<Persona>> GetPersonas();

        Task<Persona> GetPersona(int id); 
        Task InsertPersona(Persona persona);        

        Task InsertProfesor(Profesor profe);

        Task<bool> UpdateProfesor(Persona profe);

        //Task<IEnumerable<Alumno>> GetProfes();

        Task InsertAlumno(Alumno alumno);

        Task<bool> UpdateAlumno(Persona alumno);
        

        //Task<IEnumerable<Alumno>> GetAlumnos();

    }
}
