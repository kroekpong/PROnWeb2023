using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210622_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rnPrItems",
                columns: table => new
                {
                    Rn_Id = table.Column<int>(nullable: false),
                    Pr_Item_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rnPrItems");
        }
    }
}
