using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_211009_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Af_Version",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Appr_Status",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Approver_id",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Approver_role",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Is_Disabled",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "List_Level",
                table: "PRHeaders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PRHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Af_Version",
                table: "PRHeaders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appr_Status",
                table: "PRHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Approver_id",
                table: "PRHeaders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Approver_role",
                table: "PRHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Disabled",
                table: "PRHeaders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "List_Level",
                table: "PRHeaders",
                type: "int",
                nullable: true);
        }
    }
}
