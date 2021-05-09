using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlMedico.Api.Migrations
{
    public partial class CitaChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cita",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCita",
                value: new DateTime(2021, 5, 8, 20, 41, 19, 622, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 20, 41, 19, 616, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 20, 41, 19, 619, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 20, 41, 19, 619, DateTimeKind.Local).AddTicks(7164));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cita",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCita",
                value: new DateTime(2021, 5, 8, 18, 43, 37, 389, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 43, 37, 383, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 43, 37, 385, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 43, 37, 385, DateTimeKind.Local).AddTicks(3232));
        }
    }
}
