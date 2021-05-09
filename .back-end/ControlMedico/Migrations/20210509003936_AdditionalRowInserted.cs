using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlMedico.Api.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 39, 35, 161, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 39, 35, 162, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "FechaNacimiento", "Genero", "Identificacion", "NombreCompleto", "Residencia", "Telefono", "TipoIdentificacion" },
                values: new object[] { 2, new DateTime(2021, 5, 8, 18, 39, 35, 162, DateTimeKind.Local).AddTicks(9062), (byte)1, "501470061", "Eida Arroyo", "Guanacaste", "84107790", (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 32, 39, 657, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 32, 39, 661, DateTimeKind.Local).AddTicks(5827));
        }
    }
}
