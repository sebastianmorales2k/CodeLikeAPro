using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicattion1.Migrations
{
    public partial class addIndexToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
