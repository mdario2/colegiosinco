using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;

namespace Colegio.Infraestructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Persona, PersonaDto>();
            CreateMap<PersonaDto, Persona>();

            CreateMap<Profesor, ProfesorDto>();
            CreateMap<ProfesorDto, Profesor>();

            CreateMap<Alumno, AlumnoDto>();
            CreateMap<AlumnoDto, Alumno>();

            CreateMap<Materia, MateriaDto>();
            CreateMap<MateriaDto, Materia>();

        }
    }
}
