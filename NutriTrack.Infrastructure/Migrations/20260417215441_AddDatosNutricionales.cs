using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriTrack.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDatosNutricionales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Altura",
                table: "Pacientes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Calorias",
                table: "Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Peso",
                table: "Pacientes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Calorias",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Pacientes");
        }
    }
}
