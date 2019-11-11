using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniversityProject.Migrations
{
    public partial class NewMig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Reservations",
                nullable: false,
                defaultValue: "");
        }
    }
}
