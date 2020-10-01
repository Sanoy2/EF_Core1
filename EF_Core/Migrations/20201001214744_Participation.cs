using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class Participation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseParticipation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId1 = table.Column<int>(nullable: true),
                    CourseId1 = table.Column<int>(nullable: true),
                    CourseId = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseParticipation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseParticipation_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseParticipation_Courses_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseParticipation_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseParticipation_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_CourseId",
                table: "CourseParticipation",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_CourseId1",
                table: "CourseParticipation",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_StudentId",
                table: "CourseParticipation",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipation_StudentId1",
                table: "CourseParticipation",
                column: "StudentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseParticipation");
        }
    }
}
