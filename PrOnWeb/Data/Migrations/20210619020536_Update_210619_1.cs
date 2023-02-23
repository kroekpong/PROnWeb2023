using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210619_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accounting_Appr",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "Co_Signer_Appr",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "Need_Accounting",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "Need_cosign",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "PrAmount",
                table: "PRItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Rn_When",
                table: "ReturningNotes",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Purchasing_Staff",
                table: "PRItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Purchasing_Staff_Id",
                table: "PRItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Purchasing_Staff",
                table: "PRItems");

            migrationBuilder.DropColumn(
                name: "Purchasing_Staff_Id",
                table: "PRItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Rn_When",
                table: "ReturningNotes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Accounting_Appr",
                table: "PRItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Co_Signer_Appr",
                table: "PRItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Need_Accounting",
                table: "PRItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Need_cosign",
                table: "PRItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PrAmount",
                table: "PRItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
