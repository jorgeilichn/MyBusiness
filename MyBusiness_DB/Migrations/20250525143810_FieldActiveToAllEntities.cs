using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class FieldActiveToAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UnitOfMeasurementActive",
                schema: "store",
                table: "UnitOfMeasurement",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProductByOrderActive",
                schema: "store",
                table: "ProductByOrder",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProductActive",
                schema: "store",
                table: "Product",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                schema: "store",
                table: "Order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OrderStatus",
                schema: "store",
                table: "Order",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BrandActive",
                schema: "store",
                table: "Brand",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "BrandActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "BrandActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "BrandActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 4,
                column: "BrandActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 1,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 2,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 3,
                columns: new[] { "UnitOfMeasurementActive", "UnitOfMeasurementName" },
                values: new object[] { false, "Gramo" });

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 4,
                columns: new[] { "UnitOfMeasurementActive", "UnitOfMeasurementInitials", "UnitOfMeasurementName" },
                values: new object[] { false, "Lb", "Libra" });

            migrationBuilder.InsertData(
                schema: "store",
                table: "UnitOfMeasurement",
                columns: new[] { "UnitOfMeasurementId", "UnitOfMeasurementActive", "UnitOfMeasurementInitials", "UnitOfMeasurementName" },
                values: new object[,]
                {
                    { 5, false, "m", "Metro" },
                    { 6, false, "cm", "Centímetro" },
                    { 7, false, "ml", "Mililitro" },
                    { 8, false, "L", "Litro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "UnitOfMeasurementActive",
                schema: "store",
                table: "UnitOfMeasurement");

            migrationBuilder.DropColumn(
                name: "ProductByOrderActive",
                schema: "store",
                table: "ProductByOrder");

            migrationBuilder.DropColumn(
                name: "ProductActive",
                schema: "store",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "store",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                schema: "store",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BrandActive",
                schema: "store",
                table: "Brand");

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 3,
                column: "UnitOfMeasurementName",
                value: "gramos");

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 4,
                columns: new[] { "UnitOfMeasurementInitials", "UnitOfMeasurementName" },
                values: new object[] { "Lbs", "Libras" });
        }
    }
}
