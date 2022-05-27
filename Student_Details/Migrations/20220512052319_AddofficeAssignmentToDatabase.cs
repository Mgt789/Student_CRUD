using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Details.Migrations
{
    public partial class AddofficeAssignmentToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "officeAssignment",
                columns: table => new
                {
                    officeAssignment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    officeAssignment_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_officeAssignment", x => x.officeAssignment_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "officeAssignment");
        }
    }
}
