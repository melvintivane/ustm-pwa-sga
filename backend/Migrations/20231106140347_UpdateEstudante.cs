using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pwa_trabalho_sga.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEstudante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "estudantes",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "estudantes");
        }
    }
}
