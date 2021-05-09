using ControlMedico.Api.Data;
using ControlMedico.Api.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlMedico.Api.Modelos
{
    public class Paciente : IEntidad
    {

        [Required]
        [StringLength(12)]
        public string Identificacion { get; set; }

        public EnumTipoIdentificacion TipoIdentificacion { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public EnumGenero Genero { get; set; }

        [Required]
        [StringLength(250)]
        public string Residencia { get; set; }

        [Required]
        [StringLength(8)]
        public string Telefono { get; set; }

        public string DesTipoIdentificacion { get { return ExtensionEnum.ObtenerDescripcionEnum((EnumTipoIdentificacion)TipoIdentificacion); } }

        public string DesGenero { get { return ExtensionEnum.ObtenerDescripcionEnum((EnumGenero)Genero); } }
        
        public virtual ICollection<Cita> Cita { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
