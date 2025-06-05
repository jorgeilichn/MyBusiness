using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class FieldInStockQuantityProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "InStockQuantity",
                schema: "store",
                table: "Product",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStockQuantity",
                schema: "store",
                table: "Product");
        }
    }
}
