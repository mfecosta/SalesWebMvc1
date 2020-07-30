using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc1.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Selller_Department_DepartmentId",
                table: "Selller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Selller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Selller_Department_DepartmentId",
                table: "Selller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Selller_Department_DepartmentId",
                table: "Selller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Selller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Selller_Department_DepartmentId",
                table: "Selller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
