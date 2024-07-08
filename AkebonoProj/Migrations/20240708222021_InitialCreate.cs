using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkebonoProj.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KodeLokasi",
                table: "Lokasis",
                newName: "Kode");

            migrationBuilder.RenameColumn(
                name: "KodeItem",
                table: "Items",
                newName: "Kode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kode",
                table: "Lokasis",
                newName: "KodeLokasi");

            migrationBuilder.RenameColumn(
                name: "Kode",
                table: "Items",
                newName: "KodeItem");
        }
    }
}
