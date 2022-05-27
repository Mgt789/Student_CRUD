using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Details.Migrations
{
    public partial class AddCourseAssignmentToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseAssignments",
                columns: table => new
                {
                    courseAssignment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseAssignment_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseAssignments", x => x.courseAssignment_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseAssignments");
        }
    }
}
