﻿// <auto-generated />
using System;
using ControlMedico.Api.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlMedico.Api.Migrations
{
    [DbContext(typeof(ContextoBaseDatos))]
    [Migration("20210509003240_SeedInitialData")]
    partial class SeedInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlMedico.Api.Modelos.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Cancelada")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaCita")
                        .HasColumnType("datetime");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<byte?>("TipoCita")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("ControlMedico.Api.Modelos.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Genero")
                        .HasColumnType("tinyint");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Residencia")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<byte>("TipoIdentificacion")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Paciente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(2021, 5, 8, 18, 32, 39, 657, DateTimeKind.Local).AddTicks(7113),
                            Genero = (byte)2,
                            Identificacion = "114270541",
                            NombreCompleto = "José Rodríguez",
                            Residencia = "Alajuela",
                            Telefono = "84107796",
                            TipoIdentificacion = (byte)1
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(2021, 5, 8, 18, 32, 39, 661, DateTimeKind.Local).AddTicks(5827),
                            Genero = (byte)2,
                            Identificacion = "601660017",
                            NombreCompleto = "Greddy Rodríguez",
                            Residencia = "Guanacaste",
                            Telefono = "84107795",
                            TipoIdentificacion = (byte)1
                        });
                });

            modelBuilder.Entity("ControlMedico.Api.Modelos.Cita", b =>
                {
                    b.HasOne("ControlMedico.Api.Modelos.Paciente", "InfoPaciente")
                        .WithMany("Cita")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoPaciente");
                });

            modelBuilder.Entity("ControlMedico.Api.Modelos.Paciente", b =>
                {
                    b.Navigation("Cita");
                });
#pragma warning restore 612, 618
        }
    }
}
