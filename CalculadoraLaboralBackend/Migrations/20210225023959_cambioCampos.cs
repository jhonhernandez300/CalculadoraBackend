using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculadoraLaboralBackend.Migrations
{
    public partial class cambioCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasDiurnas",
                table: "Servicio");

            migrationBuilder.RenameColumn(
                name: "HorasNocturnas",
                table: "Servicio",
                newName: "CantidadDeHoras");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Servicio",
                newName: "FechaInicial");

            migrationBuilder.RenameColumn(
                name: "DiaDeLaSemana",
                table: "Servicio",
                newName: "TipoDeHoras");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinal",
                table: "Servicio",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaFinal",
                table: "Servicio");

            migrationBuilder.RenameColumn(
                name: "TipoDeHoras",
                table: "Servicio",
                newName: "DiaDeLaSemana");

            migrationBuilder.RenameColumn(
                name: "FechaInicial",
                table: "Servicio",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "CantidadDeHoras",
                table: "Servicio",
                newName: "HorasNocturnas");

            migrationBuilder.AddColumn<int>(
                name: "HorasDiurnas",
                table: "Servicio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
