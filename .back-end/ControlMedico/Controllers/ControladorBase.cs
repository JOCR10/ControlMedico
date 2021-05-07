using ControlMedico.Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlMedico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ControladorBase<TEntidad, TRepositorio> : ControllerBase
        where TEntidad : class, IEntidad
        where TRepositorio : IRepositorio<TEntidad>
    {
        private readonly TRepositorio repositorio;

        public ControladorBase(TRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntidad>>> Get()
        {
            return await repositorio.Consultar();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntidad>> Get(int id)
        {
            var paciente = await repositorio.Obtener(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return paciente;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntidad paciente)
        {
            if (id != paciente.Id)
            {
                return BadRequest();
            }
            await repositorio.Actualizar(paciente);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntidad>> Post(TEntidad paciente)
        {
            await repositorio.Agregar(paciente);
            return CreatedAtAction("Get", new { id = paciente.Id }, paciente);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntidad>> Delete(int id)
        {
            var paciente = await repositorio.Eliminar(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return paciente;
        }

    }
}
