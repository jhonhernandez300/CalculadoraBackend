using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculadoraLaboralBackend.Migrations
{
    public partial class camposIgualesAlFront : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tecnico",
                table: "Servicio",
                newName: "tecnico");

            migrationBuilder.RenameColumn(
                name: "ServicioRealizado",
                table: "Servicio",
                newName: "servicioRealizado");

            migrationBuilder.RenameColumn(
                name: "SemanaDelAno",
                table: "Servicio",
                newName: "semanaDelAno");

            migrationBuilder.RenameColumn(
                name: "CantidadDeHoras",
                table: "Servicio",
                newName: "cantidadDeHoras");

            migrationBuilder.RenameColumn(
                name: "TipoDeHoras",
                table: "Servicio",
                newName: "tipoDeHora");

            migrationBuilder.RenameColumn(
                name: "HoraInicial",
                table: "Servicio",
                newName: "horaDeInicio");

            migrationBuilder.RenameColumn(
                name: "HoraFinal",
                table: "Servicio",
                newName: "horaDeFinalizacion");

            migrationBuilder.RenameColumn(
                name: "FechaInicial",
                table: "Servicio",
                newName: "fechaDeInicio");

            migrationBuilder.RenameColumn(
                name: "FechaFinal",
                table: "Servicio",
                newName: "fechaDeFinalizacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tecnico",
                table: "Servicio",
                newName: "Tecnico");

            migrationBuilder.RenameColumn(
                name: "servicioRealizado",
                table: "Servicio",
                newName: "ServicioRealizado");

            migrationBuilder.RenameColumn(
                name: "semanaDelAno",
                table: "Servicio",
                newName: "SemanaDelAno");

            migrationBuilder.RenameColumn(
                name: "cantidadDeHoras",
                table: "Servicio",
                newName: "CantidadDeHoras");

            migrationBuilder.RenameColumn(
                name: "tipoDeHora",
                table: "Servicio",
                newName: "TipoDeHoras");

            migrationBuilder.RenameColumn(
                name: "horaDeInicio",
                table: "Servicio",
                newName: "HoraInicial");

            migrationBuilder.RenameColumn(
                name: "horaDeFinalizacion",
                table: "Servicio",
                newName: "HoraFinal");

            migrationBuilder.RenameColumn(
                name: "fechaDeInicio",
                table: "Servicio",
                newName: "FechaInicial");

            migrationBuilder.RenameColumn(
                name: "fechaDeFinalizacion",
                table: "Servicio",
                newName: "FechaFinal");
        }
    }
}
