using ControlMedico.Api.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Data.EFCore
{
    public class RepositorioPaciente : Repositorio<Paciente, ContextoBaseDatos>
    {
        public RepositorioPaciente(ContextoBaseDatos context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
