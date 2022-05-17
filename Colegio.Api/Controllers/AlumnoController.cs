using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public AlumnoController(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
        }

       

        [HttpPost]
        public async Task<IActionResult> PostAlumno(PersonaDto personadto)
        {
            var persona = _mapper.Map<Persona>(personadto);
            await _personaRepository.InsertPersona(persona);

            AlumnoDto alumnodto = new();
            var alumno = _mapper.Map<Alumno>(alumnodto);
            alumno.IdPersona = persona.IdPersona;
            await _personaRepository.InsertAlumno(alumno);
            return Ok(alumno);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PersonaDto personaDto)
        {
            var alumno = _mapper.Map<Persona>(personaDto);
            alumno.IdPersona = id;

            await _personaRepository.UpdateAlumno(alumno);
            return Ok(alumno);
        }

    }
}
