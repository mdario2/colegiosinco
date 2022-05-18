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
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaRepository _materiaRepository;
        private readonly IMapper _mapper;

        public MateriaController(IMateriaRepository materiaRepository, IMapper mapper)
        {
            _materiaRepository = materiaRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(MateriaDto materiadto)
        {
            var materia = _mapper.Map<Materia>(materiadto);
            await _materiaRepository.Insert(materia);
            return Ok(materia);
        }

        [HttpPut]
        public async Task<IActionResult> AsignarMateriaAProfe(MateriaDto materiadto, ProfesorDto profeDto)
        {
            var profe = _mapper.Map<Profesor>(profeDto);
            var materia = _mapper.Map<Materia>(materiadto);
            materia.IdPersona = profe.IdPersona;

            await _materiaRepository.AsignarMateriaAProfesor(materia,profe);
            return Ok(materia);
        }

    }
}
