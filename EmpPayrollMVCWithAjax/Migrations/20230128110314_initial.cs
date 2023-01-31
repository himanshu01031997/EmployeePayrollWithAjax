using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpPayrollMVCWithAjax.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ProfileImg = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.EmpID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeData");
        }
    }
}
