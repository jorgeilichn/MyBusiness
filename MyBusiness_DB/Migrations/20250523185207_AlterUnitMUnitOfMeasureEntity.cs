using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class AlterUnitMUnitOfMeasureEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasure",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureName");

            migrationBuilder.RenameColumn(
                name: "UnitMName",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureInitial");

            migrationBuilder.RenameColumn(
                name: "UnitMId",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasureId");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementUnitMId",
                table: "Product",
                newName: "UnitOfMeasurementUnitMUnitOfMeasureId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementUnitMId",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementUnitMUnitOfMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMUnitOfMeasu~",
                table: "Product",
                column: "UnitOfMeasurementUnitMUnitOfMeasureId",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitMUnitOfMeasureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMUnitOfMeasu~",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureName",
                table: "UnitOfMeasurement",
                newName: "UnitMUnitOfMeasure");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureInitial",
                table: "UnitOfMeasurement",
                newName: "UnitMName");

            migrationBuilder.RenameColumn(
                name: "UnitMUnitOfMeasureId",
                table: "UnitOfMeasurement",
                newName: "UnitMId");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementUnitMUnitOfMeasureId",
                table: "Product",
                newName: "UnitOfMeasurementUnitMId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementUnitMUnitOfMeasureId",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementUnitMId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementUnitMId",
                table: "Product",
                column: "UnitOfMeasurementUnitMId",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitMId");
        }
    }
}
