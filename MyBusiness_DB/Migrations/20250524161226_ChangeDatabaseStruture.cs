using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyBusiness_DB.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDatabaseStruture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchemaTest",
                schema: "store");

            migrationBuilder.RenameTable(
                name: "UnitOfMeasurement",
                newName: "UnitOfMeasurement",
                newSchema: "store");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Product",
                newSchema: "store");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brand",
                newSchema: "store");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UnitOfMeasurement",
                schema: "store",
                newName: "UnitOfMeasurement");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "store",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Brand",
                schema: "store",
                newName: "Brand");

            migrationBuilder.CreateTable(
                name: "SchemaTest",
                schema: "store",
                columns: table => new
                {
                    SchemaTestId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SchemaTestName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemaTest", x => x.SchemaTestId);
                });
        }
    }
}
