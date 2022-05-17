using Colegio.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colegio.Infraestructure.Data.Configurations
{
    public class ProfesorConfiguration : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.HasKey(e => e.IdPersona);

            builder.ToTable("profesor");

            builder.Property(e => e.IdPersona)
                .ValueGeneratedNever()
                .HasColumnName("ID_Persona");

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithOne(p => p.Profesor)
                .HasForeignKey<Profesor>(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_profesor_persona");
        }
    }
}
