using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class SetTrueActiveFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "BrandActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "BrandActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "BrandActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 4,
                column: "BrandActive",
                value: true);

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[] { 5, true, "Vima" });

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 1,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 2,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 3,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 4,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 5,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 6,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 7,
                column: "UnitOfMeasurementActive",
                value: true);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 8,
                column: "UnitOfMeasurementActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 5);

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

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[] { 6, false, "Vima" });

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
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 4,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 5,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 6,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 7,
                column: "UnitOfMeasurementActive",
                value: false);

            migrationBuilder.UpdateData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 8,
                column: "UnitOfMeasurementActive",
                value: false);
        }
    }
}
