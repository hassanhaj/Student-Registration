using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRegistration.Web.Migrations
{
    public partial class StudentMobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobileNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Students");
        }
    }
}
