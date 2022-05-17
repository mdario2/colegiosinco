using AutoMapper;
using Colegio.Core.DTOs;
using Colegio.Core.Entities;
using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public ProfesorController(IPersonaRepository personaRepository, IMapper mapper)
        {
            _personaRepository = personaRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostProfe(PersonaDto personadto)
        {
            var persona = _mapper.Map<Persona>(personadto);
            await _personaRepository.InsertPersona(persona);

            ProfesorDto profedto = new();
            var profe = _mapper.Map<Profesor>(profedto);
            profe.IdPersona = persona.IdPersona;
            await _personaRepository.InsertProfesor(profe);
            return Ok(profe);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, PersonaDto personaDto)
        {
            var profe = _mapper.Map<Persona>(personaDto);
            profe.IdPersona = id;

            await _personaRepository.UpdateProfesor(profe);
            return Ok(profe);
        }


    }
}
