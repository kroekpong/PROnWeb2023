using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_211005_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Item_close_date",
                table: "PRItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PO_DATE",
                table: "PRItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PO_ITEM_NO",
                table: "PRItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PO_No",
                table: "PRItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Staff_assign_date",
                table: "PRItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item_close_date",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "PO_DATE",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "PO_ITEM_NO",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "PO_No",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "Staff_assign_date",
                table: "PRItems");
        }
    }
}
