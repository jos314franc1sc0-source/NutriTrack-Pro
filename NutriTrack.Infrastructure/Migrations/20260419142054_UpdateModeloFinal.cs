using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriTrack.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModeloFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Consultas",
                newName: "Observaciones");

            migrationBuilder.AddColumn<int>(
                name: "CaloriasObjetivo",
                table: "Planes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Planes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Nutricionistas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Consultas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NutricionistaId",
                table: "Consultas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Consultas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriasObjetivo",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Nutricionistas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "NutricionistaId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "Observaciones",
                table: "Consultas",
                newName: "Descripcion");
        }
    }
}
