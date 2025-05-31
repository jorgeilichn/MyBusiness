using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class ReCreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMUnitOfMeasu~",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureName",
                table: "UnitOfMeasurement",
                newName: "UnitOfMeasurementName");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureInitial",
                table: "UnitOfMeasurement",
                newName: "UnitOfMeasurementInitials");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureId",
                table: "UnitOfMeasurement",
                newName: "UnitOfMeasurementId");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementUnitMUnitOfMeasureId",
                table: "Product",
                newName: "UnitOfMeasurementId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementUnitMUnitOfMeasureId",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementId",
                table: "Product",
                column: "UnitOfMeasurementId",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitOfMeasurementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementName",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureName");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementInitials",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureInitial");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementId",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureId");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementId",
                table: "Product",
                newName: "UnitOfMeasurementUnitMUnitOfMeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementId",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementUnitMUnitOfMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMUnitOfMeasu~",
                table: "Product",
                column: "UnitOfMeasurementUnitMUnitOfMeasureId",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitMUnitOfMeasureId");
        }
    }
}
