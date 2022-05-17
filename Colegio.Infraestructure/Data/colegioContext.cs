using Colegio.Core.Entities;
using Colegio.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Colegio.Infraestructure.Data
{
    public partial class colegioContext : DbContext
    {
        public colegioContext()
        {
        }

        public colegioContext(DbContextOptions<colegioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=motilon.database.windows.net;Database=colegio;User ID=mdario2;Password=Elecciones_2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlumnoConfiguration());

            modelBuilder.ApplyConfiguration(new MateriaConfiguration());

            modelBuilder.ApplyConfiguration(new PersonaConfiguration());

            modelBuilder.ApplyConfiguration(new ProfesorConfiguration());
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
