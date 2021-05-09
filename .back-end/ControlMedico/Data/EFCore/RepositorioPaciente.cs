using ControlMedico.Api.Modelos;

namespace ControlMedico.Api.Data.EFCore
{
    public class RepositorioPaciente : Repositorio<Paciente, ContextoBaseDatos>
    {
        public RepositorioPaciente(ContextoBaseDatos context) : base(context)
        {

        }
    }
}
