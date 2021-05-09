using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlMedico.Api.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "TipoIdentificacion",
                table: "Paciente",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Genero",
                table: "Paciente",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "TipoCita",
                table: "Cita",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "FechaNacimiento", "Genero", "Identificacion", "NombreCompleto", "Residencia", "Telefono", "TipoIdentificacion" },
                values: new object[] { 1, new DateTime(2021, 5, 8, 18, 32, 39, 657, DateTimeKind.Local).AddTicks(7113), (byte)2, "114270541", "José Rodríguez", "Alajuela", "84107796", (byte)1 });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "FechaNacimiento", "Genero", "Identificacion", "NombreCompleto", "Residencia", "Telefono", "TipoIdentificacion" },
                values: new object[] { 3, new DateTime(2021, 5, 8, 18, 32, 39, 661, DateTimeKind.Local).AddTicks(5827), (byte)2, "601660017", "Greddy Rodríguez", "Guanacaste", "84107795", (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "TipoIdentificacion",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Genero",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "TipoCita",
                table: "Cita",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);
        }
    }
}
