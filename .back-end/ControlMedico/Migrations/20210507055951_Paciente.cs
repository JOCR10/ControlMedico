using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlMedico.Api.Migrations
{
    public partial class Paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Paciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
