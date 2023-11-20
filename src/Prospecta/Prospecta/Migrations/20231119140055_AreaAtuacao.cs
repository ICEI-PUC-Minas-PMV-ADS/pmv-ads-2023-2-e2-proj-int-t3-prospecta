using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prospecta.Migrations
{
    /// <inheritdoc />
    public partial class AreaAtuacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaAtuacao",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AreaAtuacao",
                table: "Empresas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
