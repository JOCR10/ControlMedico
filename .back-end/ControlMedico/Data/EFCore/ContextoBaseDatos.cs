using Microsoft.EntityFrameworkCore;

namespace ControlMedico.Api.Data.EFCore
{
    public class ContextoBaseDatos : DbContext
    {
        public ContextoBaseDatos (DbContextOptions<ContextoBaseDatos> options)
            : base(options)
        {
        }

        public DbSet<ControlMedico.Api.Modelos.Paciente> Paciente { get; set; }
    }
}
