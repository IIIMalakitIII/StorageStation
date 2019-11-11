using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniversityProject.Migrations
{
    public partial class NewMig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserInfos",
                nullable: true);
        }
    }
}
