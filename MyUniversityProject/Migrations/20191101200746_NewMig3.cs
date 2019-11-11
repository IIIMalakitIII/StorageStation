using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniversityProject.Migrations
{
    public partial class NewMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassportId",
                table: "UserInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassportId",
                table: "UserInfos",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
