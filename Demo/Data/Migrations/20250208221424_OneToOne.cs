using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptManageId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptManageId",
                table: "Employees",
                column: "DeptManageId",
                unique: true,
                filter: "[DeptManageId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptManageId",
                table: "Employees",
                column: "DeptManageId",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptManageId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptManageId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeptManageId",
                table: "Employees");
        }
    }
}
