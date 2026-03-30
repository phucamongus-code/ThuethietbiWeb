using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThuethietbiWeb.Migrations
{
    /// <inheritdoc />
    public partial class ThemHinhAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "ThietBis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "ThietBis");
        }
    }
}
