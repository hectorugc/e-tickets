using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Tickets.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Moviecategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Movies",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "Moviecategory");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "MyProperty");
        }
    }
}
