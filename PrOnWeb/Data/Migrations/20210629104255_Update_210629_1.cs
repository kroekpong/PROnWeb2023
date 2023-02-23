using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210629_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rn_Id",
                table: "ReturningNotes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rn_Id",
                table: "ReturningNotes");
        }
    }
}
