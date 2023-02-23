using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210623_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rn_By_Id",
                table: "ReturningNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rn_Status",
                table: "ReturningNotes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rn_By_Id",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Status",
                table: "ReturningNotes");
        }
    }
}
