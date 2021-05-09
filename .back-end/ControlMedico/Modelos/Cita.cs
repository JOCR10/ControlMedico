using ControlMedico.Api.Data;
using ControlMedico.Api.Enumerados;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlMedico.Api.Modelos
{
    public class Cita : IEntidad
    {
        [Column(TypeName = "datetime")]
        public DateTime? FechaCita { get; set; }
        public EnumTipoCita? TipoCita { get; set; }
        public string DesTipoCita { get { return ExtensionEnum.ObtenerDescripcionEnum((EnumTipoCita)TipoCita); } }
        public bool? Cancelada { get; set; }

        public int IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public virtual Paciente Paciente { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
