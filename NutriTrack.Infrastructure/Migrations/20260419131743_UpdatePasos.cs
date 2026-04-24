using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriTrack.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePasos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Calorias",
                table: "Pacientes",
                newName: "Pasos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pasos",
                table: "Pacientes",
                newName: "Calorias");
        }
    }
}
