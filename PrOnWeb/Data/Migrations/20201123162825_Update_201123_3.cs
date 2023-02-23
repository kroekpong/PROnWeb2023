using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_201123_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Need_CG_Concerning",
                table: "PRHeaders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Need_ISO",
                table: "PRHeaders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Need_SCA_Concerning",
                table: "PRHeaders",
                nullable: false,
                defaultValue: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Need_CG_Concerning",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Need_ISO",
                table: "PRHeaders");

            migrationBuilder.DropColumn(
                name: "Need_SCA_Concerning",
                table: "PRHeaders");
        }
    }
}
