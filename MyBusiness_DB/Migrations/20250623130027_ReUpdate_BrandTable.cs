using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class ReUpdate_BrandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[,]
                {
                    { 6, true, "La fragua" },
                    { 7, true, "Sauce" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 7);
        }
    }
}
