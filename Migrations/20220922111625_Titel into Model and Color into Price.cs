using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAutod.Migrations
{
    public partial class TitelintoModelandColorintoPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Auto",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Auto",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Auto",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Auto",
                newName: "Title");
        }
    }
}
