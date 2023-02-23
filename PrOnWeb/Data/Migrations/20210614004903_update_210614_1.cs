using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class update_210614_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pr_id",
                table: "uploadFiles");

            migrationBuilder.DropColumn(
                name: "Pr_item_id",
                table: "uploadFiles");

            migrationBuilder.AddColumn<int>(
                name: "Document_id",
                table: "uploadFiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Upload_Type",
                table: "uploadFiles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document_id",
                table: "uploadFiles");

            migrationBuilder.DropColumn(
                name: "Upload_Type",
                table: "uploadFiles");

            migrationBuilder.AddColumn<int>(
                name: "Pr_id",
                table: "uploadFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pr_item_id",
                table: "uploadFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
