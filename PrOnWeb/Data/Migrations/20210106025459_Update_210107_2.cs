using Microsoft.EntityFrameworkCore.Migrations;

namespace PrOnWeb.Data.Migrations
{
    public partial class Update_210107_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sec",
                table: "Master_Secs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Master_Roles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Org",
                table: "Master_Orgs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dep",
                table: "Master_Deps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Master_Secs_Sec",
                table: "Master_Secs",
                column: "Sec",
                unique: true,
                filter: "[Sec] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Master_Roles_Role",
                table: "Master_Roles",
                column: "Role",
                unique: true,
                filter: "[Role] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Master_Orgs_Org",
                table: "Master_Orgs",
                column: "Org",
                unique: true,
                filter: "[Org] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Master_Deps_Dep",
                table: "Master_Deps",
                column: "Dep",
                unique: true,
                filter: "[Dep] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Master_Secs_Sec",
                table: "Master_Secs");

            migrationBuilder.DropIndex(
                name: "IX_Master_Roles_Role",
                table: "Master_Roles");

            migrationBuilder.DropIndex(
                name: "IX_Master_Orgs_Org",
                table: "Master_Orgs");

            migrationBuilder.DropIndex(
                name: "IX_Master_Deps_Dep",
                table: "Master_Deps");

            migrationBuilder.AlterColumn<string>(
                name: "Sec",
                table: "Master_Secs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Master_Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Org",
                table: "Master_Orgs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dep",
                table: "Master_Deps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
