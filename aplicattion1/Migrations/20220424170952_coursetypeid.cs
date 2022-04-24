using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicattion1.Migrations
{
    public partial class coursetypeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_Name",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTypes_Description",
                table: "CourseTypes",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name_CourseTypeId",
                table: "Courses",
                columns: new[] { "Name", "CourseTypeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CourseTypes_Description",
                table: "CourseTypes");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Name_CourseTypeId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name",
                unique: true);
        }
    }
}
