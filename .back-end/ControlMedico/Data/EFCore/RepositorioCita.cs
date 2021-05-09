using ControlMedico.Api.Modelos;

namespace ControlMedico.Api.Data.EFCore
{
    public class RepositorioCita : Repositorio<Cita, ContextoBaseDatos>
    {
        public RepositorioCita(ContextoBaseDatos context) : base(context)
        {

        }
    }
}
