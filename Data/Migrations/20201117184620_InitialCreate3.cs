using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDb1.Data.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNum = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    JobRole = table.Column<string>(nullable: true),
                    BusinessTravel = table.Column<string>(nullable: true),
                    EmployeeCount = table.Column<int>(nullable: false),
                    Attrition = table.Column<string>(nullable: true),
                    WorkLifeBalance = table.Column<string>(nullable: true),
                    PerformanceRating = table.Column<int>(nullable: false),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
