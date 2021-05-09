using ControlMedico.Api.Enumerados;
using ControlMedico.Api.Modelos;
using Microsoft.EntityFrameworkCore;
using System;

namespace ControlMedico.Api.Data.EFCore
{
    public class ContextoBaseDatos : DbContext
    {
        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> options)
            : base(options)
        {
        }

        public DbSet<ControlMedico.Api.Modelos.Paciente> Paciente { get; set; }
        public DbSet<ControlMedico.Api.Modelos.Cita> Cita { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>(entity =>
            {
                entity.Property(e => e.TipoCita).HasConversion(x => (byte)x, x => (EnumTipoCita)x);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.Genero).HasConversion(x => (byte)x, x => (EnumGenero)x);
                entity.Property(e => e.TipoIdentificacion).HasConversion(x => (byte)x, x => (EnumTipoIdentificacion)x);
            });

            modelBuilder.Entity<Paciente>()
                .HasData(
            new Paciente
            {
                Id = 1,
                NombreCompleto = "José Rodríguez",
                FechaNacimiento = DateTime.Now,
                Genero = EnumGenero.Masculino,
                Identificacion = "114270541",
                TipoIdentificacion = EnumTipoIdentificacion.Fisica,
                Residencia = "Alajuela",
                Telefono = "84107796"
            },
            new Paciente
            {
                Id = 2,
                NombreCompleto = "Eida Arroyo",
                FechaNacimiento = DateTime.Now,
                Genero = EnumGenero.Femenino,
                Identificacion = "501470061",
                TipoIdentificacion = EnumTipoIdentificacion.Fisica,
                Residencia = "Guanacaste",
                Telefono = "84107790"
            },
            new Paciente
            {
                Id = 3,
                NombreCompleto = "Greddy Rodríguez",
                FechaNacimiento = DateTime.Now,
                Genero = EnumGenero.Masculino,
                Identificacion = "601660017",
                TipoIdentificacion = EnumTipoIdentificacion.Fisica,
                Residencia = "Guanacaste",
                Telefono = "84107795"
            });

            modelBuilder.Entity<Cita>()
                .HasData(
            new Cita
            {
                Id = 1,
                Cancelada = false,
                FechaCita = DateTime.Now,
                IdPaciente = 1,
                TipoCita = EnumTipoCita.MedicinaGeneral
            });
        }

    }
}
