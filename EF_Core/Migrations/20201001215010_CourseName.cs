using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class CourseName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseParticipation_Courses_CourseId1",
                table: "CourseParticipation");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseParticipation_Students_StudentId1",
                table: "CourseParticipation");

            migrationBuilder.DropIndex(
                name: "IX_CourseParticipation_CourseId1",
                table: "CourseParticipation");

            migrationBuilder.DropIndex(
                name: "IX_CourseParticipation_StudentId1",
                table: "CourseParticipation");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "CourseParticipation");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "CourseParticipation");

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "CourseParticipation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "CourseParticipation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_CourseId1",
                table: "CourseParticipation",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_StudentId1",
                table: "CourseParticipation",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseParticipation_Courses_CourseId1",
                table: "CourseParticipation",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseParticipation_Students_StudentId1",
                table: "CourseParticipation",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
