using Microsoft.AspNetCore.Mvc;
using ControlMedico.Api.Modelos;
using ControlMedico.Api.Data.EFCore;

namespace ControlMedico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControladorBase<Cita, RepositorioCita>
    {
        public CitasController(RepositorioCita repositorio) : base(repositorio)
        {
        }
    }
}
