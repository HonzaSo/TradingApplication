using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TradingApplicationWeb.Migrations
{
    /// <inheritdoc />
    public partial class FillTFinancialProductTestingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Open = table.Column<double>(type: "float", nullable: false),
                    High = table.Column<double>(type: "float", nullable: false),
                    Low = table.Column<double>(type: "float", nullable: false),
                    Close = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FinancialProducts",
                columns: new[] { "Id", "Close", "From", "High", "Low", "Open", "Symbol", "Volume" },
                values: new object[,]
                {
                    { 1, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "T", 123456 },
                    { 2, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "E", 123456 },
                    { 3, 150.87, "2023-09-01", 154.33000000000001, 150.41999999999999, 153.77500000000001, "S", 123456 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialProducts");
        }
    }
}
