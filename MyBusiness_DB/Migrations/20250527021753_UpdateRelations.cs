using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementId",
                schema: "store",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "store",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementId",
                schema: "store",
                table: "Product",
                newName: "UnitOfMeasurementID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                schema: "store",
                table: "Product",
                newName: "BrandID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementId",
                schema: "store",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BrandId",
                schema: "store",
                table: "Product",
                newName: "IX_Product_BrandID");

            migrationBuilder.AlterColumn<int>(
                name: "UnitOfMeasurementID",
                schema: "store",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                schema: "store",
                table: "Order",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandID",
                schema: "store",
                table: "Product",
                column: "BrandID",
                principalSchema: "store",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementID",
                schema: "store",
                table: "Product",
                column: "UnitOfMeasurementID",
                principalSchema: "store",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitOfMeasurementId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandID",
                schema: "store",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementID",
                schema: "store",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                schema: "store",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "UnitOfMeasurementID",
                schema: "store",
                table: "Product",
                newName: "UnitOfMeasurementId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                schema: "store",
                table: "Product",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitOfMeasurementID",
                schema: "store",
                table: "Product",
                newName: "IX_Product_UnitOfMeasurementId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BrandID",
                schema: "store",
                table: "Product",
                newName: "IX_Product_BrandId");

            migrationBuilder.AlterColumn<int>(
                name: "UnitOfMeasurementId",
                schema: "store",
                table: "Product",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                schema: "store",
                table: "Order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product",
                column: "BrandId",
                principalSchema: "store",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitOfMeasurement_UnitOfMeasurementId",
                schema: "store",
                table: "Product",
                column: "UnitOfMeasurementId",
                principalSchema: "store",
                principalTable: "UnitOfMeasurement",
                principalColumn: "UnitOfMeasurementId");
        }
    }
}
