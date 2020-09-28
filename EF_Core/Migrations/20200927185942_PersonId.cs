using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class PersonId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalIdNumber",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "PersonalIdNumber_Value",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalIdNumber_Value",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "PersonalIdNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
