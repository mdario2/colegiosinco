using Colegio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Infraestructure.Data.Configurations
{
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(e => e.IdMateria);

            builder.ToTable("materia");

            builder.Property(e => e.IdMateria).HasColumnName("Id_materia");

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codigo");

            builder.Property(e => e.IdPersona).HasColumnName("ID_Persona");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_materia_profesor");
        }
    }
}
