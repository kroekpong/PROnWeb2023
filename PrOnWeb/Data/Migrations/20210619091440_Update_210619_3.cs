using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210619_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "Af_Version",
                table: "Approval_Flows",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Af_Version",
                table: "Approval_Flows");
        }
    }
}
