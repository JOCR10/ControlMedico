using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlMedico.Api.Modelos;
using ControlMedico.Api.Data.EFCore;

namespace ControlMedico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControladorBase<Paciente, RepositorioPaciente>
    {
        public PacientesController(RepositorioPaciente repositorio) : base(repositorio)
        {
        }
    }
}
