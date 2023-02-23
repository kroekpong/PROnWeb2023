using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210705_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Import_DateTime = table.Column<DateTime>(nullable: false),
                    Raw_Record_Count = table.Column<int>(nullable: false),
                    Import_File_Name = table.Column<string>(nullable: true),
                    Good_Record_Count = table.Column<int>(nullable: false),
                    Bad_Record_Count = table.Column<int>(nullable: false),
                    Pr_Header_Id_Start = table.Column<int>(nullable: false),
                    Pr_Header_Count = table.Column<int>(nullable: false),
                    Pr_Item_Id_Start = table.Column<int>(nullable: false),
                    Pr_Item_Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportLogs");
        }
    }
}
