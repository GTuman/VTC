using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTC.Data.Migrations
{
    public partial class updateLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "Lessons",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_LevelId",
                table: "Lessons",
                newName: "IX_Lessons_SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Subjects_SubjectId",
                table: "Lessons",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Subjects_SubjectId",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Lessons",
                newName: "LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_SubjectId",
                table: "Lessons",
                newName: "IX_Lessons_LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
