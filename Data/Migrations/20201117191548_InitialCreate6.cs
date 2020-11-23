using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDb1.Data.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<int>(nullable: true),
                    YearsInCurrentRole = table.Column<int>(nullable: true),
                    LastPromotionYears = table.Column<int>(nullable: true),
                    ManagerYears = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    WorkingYears = table.Column<int>(nullable: true),
                    TrainingTime = table.Column<string>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employeenumber = table.Column<string>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    JobLevel = table.Column<string>(nullable: true),
                    JobRole = table.Column<string>(nullable: true),
                    JobSatisfaction = table.Column<string>(nullable: true),
                    OverTime = table.Column<string>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employeenum = table.Column<int>(nullable: false),
                    PercentSalaryRate = table.Column<int>(nullable: true),
                    DailyRate = table.Column<int>(nullable: true),
                    HourlyRate = table.Column<int>(nullable: true),
                    MonthlyIncome = table.Column<int>(nullable: true),
                    MonthlyRate = table.Column<int>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    DistanceFromHome = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    MartialStatus = table.Column<string>(nullable: true),
                    Over18 = table.Column<string>(nullable: true),
                    RelationshipSatisfacion = table.Column<string>(nullable: true),
                    AccessLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "JobDetails");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
