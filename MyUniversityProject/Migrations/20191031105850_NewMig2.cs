using Microsoft.EntityFrameworkCore.Migrations;

namespace MyUniversityProject.Migrations
{
    public partial class NewMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_EmployeeId1",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeId1",
                table: "Employee",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_EmployeeId1",
                table: "Employee",
                column: "EmployeeId1",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
