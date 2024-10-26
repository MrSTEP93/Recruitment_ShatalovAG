using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HostApp.Migrations
{
    /// <inheritdoc />
    public partial class Fake_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Positions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Positions", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SelectionStages",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SelectionStages", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VacancyStatuses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VacancyStatuses", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        PositionId = table.Column<int>(type: "int", nullable: true),
            //        RoleId = table.Column<int>(type: "int", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employees", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Employees_Departments_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "Departments",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Employees_Positions_PositionId",
            //            column: x => x.PositionId,
            //            principalTable: "Positions",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Employees_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vacancies",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        PositionId = table.Column<int>(type: "int", nullable: true),
            //        RoleId = table.Column<int>(type: "int", nullable: true),
            //        SuggestedSalary = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vacancies", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Vacancies_Departments_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "Departments",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vacancies_Positions_PositionId",
            //            column: x => x.PositionId,
            //            principalTable: "Positions",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vacancies_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CandidateHistories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StageId = table.Column<int>(type: "int", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CandidateHistories", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CandidateHistories_SelectionStages_StageId",
            //            column: x => x.StageId,
            //            principalTable: "SelectionStages",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Candidates",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VacancyId = table.Column<int>(type: "int", nullable: true),
            //        ResumeURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ExpectedSalary = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Candidates", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Candidates_Vacancies_VacancyId",
            //            column: x => x.VacancyId,
            //            principalTable: "Vacancies",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VanancyHistories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VanancyId = table.Column<int>(type: "int", nullable: false),
            //        StatusId = table.Column<int>(type: "int", nullable: false),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VanancyHistories", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_VanancyHistories_Vacancies_VanancyId",
            //            column: x => x.VanancyId,
            //            principalTable: "Vacancies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_VanancyHistories_VacancyStatuses_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "VacancyStatuses",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_CandidateHistories_StageId",
            //    table: "CandidateHistories",
            //    column: "StageId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Candidates_VacancyId",
            //    table: "Candidates",
            //    column: "VacancyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employees_DepartmentId",
            //    table: "Employees",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employees_PositionId",
            //    table: "Employees",
            //    column: "PositionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employees_RoleId",
            //    table: "Employees",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vacancies_DepartmentId",
            //    table: "Vacancies",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vacancies_PositionId",
            //    table: "Vacancies",
            //    column: "PositionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vacancies_RoleId",
            //    table: "Vacancies",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VanancyHistories_StatusId",
            //    table: "VanancyHistories",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VanancyHistories_VanancyId",
            //    table: "VanancyHistories",
            //    column: "VanancyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "CandidateHistories");

            //migrationBuilder.DropTable(
            //    name: "Candidates");

            //migrationBuilder.DropTable(
            //    name: "Employees");

            //migrationBuilder.DropTable(
            //    name: "VanancyHistories");

            //migrationBuilder.DropTable(
            //    name: "SelectionStages");

            //migrationBuilder.DropTable(
            //    name: "Vacancies");

            //migrationBuilder.DropTable(
            //    name: "VacancyStatuses");

            //migrationBuilder.DropTable(
            //    name: "Departments");

            //migrationBuilder.DropTable(
            //    name: "Positions");

            //migrationBuilder.DropTable(
            //    name: "Roles");
        }
    }
}
