using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateDBReinitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[] { 6, false, "Vima" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[] { 5, false, "Vima" });
        }
    }
}
