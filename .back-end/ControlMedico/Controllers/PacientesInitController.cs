using ControlMedico.Api.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacientesInitController : ControllerBase
    {
        private IEnumerable<Paciente> Pacientes = Enumerable.Range(0, 3).Select(index => new Paciente
        {
            Identificacion = "114270541",
            TipoIdentificacion = Enumerados.EnumTipoIdentificacion.Fisica,
            NombreCompleto = "Paciente " + (index + 1),
            FechaNacimiento = DateTime.Now,
            Genero = Enumerados.EnumGenero.Masculino,
            Residencia = "Alajuela",
            Telefono = "84107796"
        }).ToArray();

        private readonly ILogger<PacientesInitController> _logger;

        public PacientesInitController(ILogger<PacientesInitController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Pacientes);
        }
    }
}
