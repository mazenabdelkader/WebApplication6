using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Acess_Layer.Migrations
{
    /// <inheritdoc />
    public partial class employee_department_relationship2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "employees",
                newName: "Id");
        }
    }
}
