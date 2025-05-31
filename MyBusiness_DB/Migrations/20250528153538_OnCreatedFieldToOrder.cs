using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class OnCreatedFieldToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnCreated",
                schema: "store",
                table: "Order",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "store",
                table: "Brand",
                columns: new[] { "BrandId", "BrandActive", "BrandName" },
                values: new object[] { 5, false, "Vima" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "store",
                table: "Brand",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "OnCreated",
                schema: "store",
                table: "Order");
        }
    }
}
