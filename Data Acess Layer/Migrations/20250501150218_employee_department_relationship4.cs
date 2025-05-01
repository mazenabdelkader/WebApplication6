using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Acess_Layer.Migrations
{
    /// <inheritdoc />
    public partial class employee_department_relationship4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "employees",
                newName: "EmployeeId"); // Rename duplicate 'id' column to 'EmployeeId'

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "employees",
                newName: "DepartmentId"); // Rename 'employee_id' to 'DepartmentId' for clarity

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Name",
                table: "employees",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_Name",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "employees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "employees",
                newName: "employee_id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "employee_id",
                table: "employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");
        }
    }
    }
