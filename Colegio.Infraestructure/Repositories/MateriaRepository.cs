using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Colegio.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Infraestructure.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly colegioContext _context;

        public MateriaRepository(colegioContext context)
        {
            _context = context;
        }

        public async Task<bool> AsignarMateriaAProfesor(Materia m,  Profesor profe)
        {
            var currentMateria = await GetMateria(m.IdMateria);
            currentMateria.IdPersona = profe.IdPersona;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;

        }
       

        public async Task<Materia> GetMateria(int id)
        {
            var materia = await _context.Materia.FirstOrDefaultAsync(x => x.IdMateria == id);
            return materia;
        }

        public async Task Insert(Materia materia)
        {
            _context.Materia.Add(materia);
            await _context.SaveChangesAsync();
        }
    }
}
