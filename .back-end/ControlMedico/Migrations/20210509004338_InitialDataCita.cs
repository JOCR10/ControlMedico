using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlMedico.Api.Migrations
{
    public partial class InitialDataCita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cita",
                columns: new[] { "Id", "Cancelada", "FechaCita", "IdPaciente", "TipoCita" },
                values: new object[] { 1, false, new DateTime(2021, 5, 8, 18, 43, 37, 389, DateTimeKind.Local).AddTicks(4602), 1, (byte)1 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cita",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 39, 35, 161, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 39, 35, 162, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 5, 8, 18, 39, 35, 162, DateTimeKind.Local).AddTicks(9093));
        }
    }
}
