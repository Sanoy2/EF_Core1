using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class Card2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCards_Students_StudentId1",
                table: "StudentCards");

            migrationBuilder.DropIndex(
                name: "IX_StudentCards_StudentId1",
                table: "StudentCards");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "StudentCards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "StudentCards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCards_StudentId1",
                table: "StudentCards",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCards_Students_StudentId1",
                table: "StudentCards",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
