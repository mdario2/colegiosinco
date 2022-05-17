using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Colegio.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Infraestructure.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly colegioContext _context;

        public PersonaRepository(colegioContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Persona>> GetPersonas()
        {
            var personas = await _context.Personas.ToListAsync();

            return personas;
        }

        public async Task<Persona> GetPersona(int id)
        {
            var persona = await _context.Personas.FirstOrDefaultAsync(x => x.IdPersona == id);

            return persona;
        }

        public async Task<Profesor> GetProfe(int id)
        {
            var profe = await _context.Profesors.FirstOrDefaultAsync(x => x.IdPersona == id);

            return profe;
        }

        public async Task<bool> UpdateProfesor(Persona profe)
        {
            var currentProfesor = await GetPersona(profe.IdPersona);
            currentProfesor.Nombres = profe.Nombres;
            currentProfesor.Apellidos = profe.Apellidos;
            currentProfesor.Identificacion = profe.Identificacion;
            currentProfesor.Edad = profe.Edad;
            currentProfesor.Direccion = profe.Direccion;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;

        }

        public async Task InsertAlumno(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            await _context.SaveChangesAsync();
        }
       

        public async Task<bool> UpdateAlumno(Persona alumno)
        {
            var currentAlumno = await GetPersona(alumno.IdPersona);
            currentAlumno.Nombres = alumno.Nombres;
            currentAlumno.Apellidos = alumno.Apellidos;
            currentAlumno.Identificacion = alumno.Identificacion;
            currentAlumno.Edad = alumno.Edad;
            currentAlumno.Direccion = alumno.Direccion;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task InsertPersona(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

        }

        public async Task InsertProfesor(Profesor profe)
        {
            _context.Profesors.Add(profe);
            await _context.SaveChangesAsync();
        }

        

    }
}
