using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculadoraLaboralBackend.Migrations
{
    public partial class cambioNombreDatosModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dia",
                table: "Servicio",
                newName: "DiaDeLaSemana");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiaDeLaSemana",
                table: "Servicio",
                newName: "Dia");
        }
    }
}
