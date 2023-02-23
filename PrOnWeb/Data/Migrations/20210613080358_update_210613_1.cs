using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class update_210613_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rn_Attach",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Description",
                table: "ReturningNotes");

            migrationBuilder.AddColumn<string>(
                name: "Rn_By",
                table: "ReturningNotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rn_Memo1",
                table: "ReturningNotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rn_Memo2",
                table: "ReturningNotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rn_Memo3",
                table: "ReturningNotes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rn_Reason",
                table: "ReturningNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Rn_When",
                table: "ReturningNotes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rn_By",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Memo1",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Memo2",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Memo3",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_Reason",
                table: "ReturningNotes");

            migrationBuilder.DropColumn(
                name: "Rn_When",
                table: "ReturningNotes");

            migrationBuilder.AddColumn<string>(
                name: "Rn_Attach",
                table: "ReturningNotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rn_Description",
                table: "ReturningNotes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
