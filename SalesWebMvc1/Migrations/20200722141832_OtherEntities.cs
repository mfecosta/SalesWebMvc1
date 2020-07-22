using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc1.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Selller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BaseSalary = table.Column<double>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selller_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SallesRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    StatusId = table.Column<int>(nullable: true),
                    SellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SallesRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SallesRecord_Selller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Selller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SallesRecord_SallesRecord_StatusId",
                        column: x => x.StatusId,
                        principalTable: "SallesRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SallesRecord_SellerId",
                table: "SallesRecord",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SallesRecord_StatusId",
                table: "SallesRecord",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Selller_DepartmentId",
                table: "Selller",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SallesRecord");

            migrationBuilder.DropTable(
                name: "Selller");
        }
    }
}
