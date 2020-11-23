using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDb1.Data.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<string>(nullable: true),
                    YearsAtCompany = table.Column<string>(nullable: true),
                    StockOption = table.Column<string>(nullable: true),
                    NumCompanies = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(nullable: true),
                    Department1 = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    EducationField = table.Column<string>(nullable: true),
                    EnvSatisfaction = table.Column<string>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
