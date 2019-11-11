using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniversityProject.Migrations
{
    public partial class NewMig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Employee");
        }
    }
}
