using Microsoft.EntityFrameworkCore.Migrations;

namespace migrationTest.Migrations
{
    public partial class PhonesChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Phones",
                newName: "Price_");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price_",
                table: "Phones",
                newName: "Price");
        }
    }
}
