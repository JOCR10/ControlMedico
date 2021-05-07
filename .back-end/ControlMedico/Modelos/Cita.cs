using ControlMedico.Api.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Modelos
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime? FechaCita { get; set; }
        public int IdPaciente { get; set; }
        public EnumTipoCita? TipoCita { get; set; }
        public string DesTipoCita { get { return ExtensionEnum.ObtenerDescripcionEnum((EnumTipoCita)TipoCita); } }
        public bool? Cancelada { get; set; }
        public virtual Paciente InfoPaciente { get; set; }
    }
}
