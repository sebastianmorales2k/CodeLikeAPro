using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicattion1.Migrations
{
    public partial class allEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_Name_CourseTypeId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DocumentType",
                newName: "Id_DocumentType");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name",
                table: "Courses",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_Name",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Id_DocumentType",
                table: "DocumentType",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Name_CourseTypeId",
                table: "Courses",
                columns: new[] { "Name", "CourseTypeId" },
                unique: true);
        }
    }
}
