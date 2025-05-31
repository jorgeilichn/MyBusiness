using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class EntityOrderAndRelProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                schema: "store",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductByOrder",
                schema: "store",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "integer", nullable: false),
                    OrderID = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductByOrder", x => new { x.ProductID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_ProductByOrder_Order_OrderID",
                        column: x => x.OrderID,
                        principalSchema: "store",
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductByOrder_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "store",
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "Otro" },
                    { 2, "Bravo" },
                    { 3, "Dos coronas" },
                    { 4, "Gouda" }
                });

            migrationBuilder.InsertData(
                schema: "store",
                table: "UnitOfMeasurement",
                columns: new[] { "UnitOfMeasurementId", "UnitOfMeasurementInitials", "UnitOfMeasurementName" },
                values: new object[,]
                {
                    { 1, "U", "Unidad" },
                    { 2, "Kg", "Kilogramo" },
                    { 3, "g", "gramos" },
                    { 4, "Lbs", "Libras" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductByOrder_OrderID",
                schema: "store",
                table: "ProductByOrder",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductByOrder",
                schema: "store");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "store");

            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "UnitOfMeasurement",
                keyColumn: "UnitOfMeasurementId",
                keyValue: 4);
        }
    }
}
