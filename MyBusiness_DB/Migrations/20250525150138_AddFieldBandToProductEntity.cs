using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldBandToProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                schema: "store",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product",
                column: "BrandId",
                principalSchema: "store",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                schema: "store",
                table: "Product",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Brand_BrandId",
                schema: "store",
                table: "Product",
                column: "BrandId",
                principalSchema: "store",
                principalTable: "Brand",
                principalColumn: "BrandId");
        }
    }
}
