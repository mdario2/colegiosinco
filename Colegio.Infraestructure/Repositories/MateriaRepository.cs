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
        public async Task<IEnumerable<Materia>> Get()
        {
            var materias = await _context.Materia.ToListAsync();
            return materias;
        }

        public async Task Insert(Materia materia)
        {
            _context.Materia.Add(materia);
            await _context.SaveChangesAsync();
        }
    }
}
