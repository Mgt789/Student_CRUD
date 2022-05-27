using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Details.Migrations
{
    public partial class addEnrolmentDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enrolments",
                columns: table => new
                {
                    Enrolment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrolments", x => x.Enrolment_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enrolments");
        }
    }
}
