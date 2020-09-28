using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class StudentCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentCards",
                columns: table => new
                {
                    Number = table.Column<string>(nullable: false),
                    StudentId1 = table.Column<int>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCards", x => x.Number);
                    table.ForeignKey(
                        name: "FK_StudentCards_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCards_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCards_StudentId",
                table: "StudentCards",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCards_StudentId1",
                table: "StudentCards",
                column: "StudentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCards");
        }
    }
}
