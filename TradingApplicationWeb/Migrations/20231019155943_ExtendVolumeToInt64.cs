using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingApplicationWeb.Migrations
{
    /// <inheritdoc />
    public partial class ExtendVolumeToInt64 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Volume",
                table: "FinancialProducts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Volume",
                value: 123456L);

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Volume",
                value: 123456L);

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Volume",
                value: 123456L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Volume",
                table: "FinancialProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Volume",
                value: 123456);

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Volume",
                value: 123456);

            migrationBuilder.UpdateData(
                table: "FinancialProducts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Volume",
                value: 123456);
        }
    }
}
