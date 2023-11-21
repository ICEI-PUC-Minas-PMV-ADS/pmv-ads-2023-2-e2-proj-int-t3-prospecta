using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prospecta.Migrations
{
    /// <inheritdoc />
    public partial class favorito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Favorito",
                table: "Leads",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favorito",
                table: "Leads");
        }
    }
}
