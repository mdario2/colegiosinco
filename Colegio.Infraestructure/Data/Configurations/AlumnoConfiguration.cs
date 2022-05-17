using Colegio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Infraestructure.Data.Configurations
{
    public class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.HasKey(e => e.IdPersona);

            builder.ToTable("alumno");

            builder.Property(e => e.IdPersona)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Persona");

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithOne(p => p.Alumno)
                .HasForeignKey<Alumno>(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alumno_persona");
        }
    }
}
