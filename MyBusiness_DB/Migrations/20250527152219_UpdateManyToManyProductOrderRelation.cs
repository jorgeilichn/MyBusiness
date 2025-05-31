using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManyToManyProductOrderRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductByOrder",
                schema: "store",
                table: "ProductByOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductByOrder_OrderID",
                schema: "store",
                table: "ProductByOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductByOrder",
                schema: "store",
                table: "ProductByOrder",
                columns: new[] { "OrderID", "ProductID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductByOrder_ProductID",
                schema: "store",
                table: "ProductByOrder",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductByOrder",
                schema: "store",
                table: "ProductByOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductByOrder_ProductID",
                schema: "store",
                table: "ProductByOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductByOrder",
                schema: "store",
                table: "ProductByOrder",
                columns: new[] { "ProductID", "OrderID" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductByOrder_OrderID",
                schema: "store",
                table: "ProductByOrder",
                column: "OrderID");
        }
    }
}
