using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DovizTakipServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrencyType",
                table: "Currencies",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Currencies",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Currencies",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Currencies",
                newName: "CurrencyType");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Currencies",
                newName: "CreatAt");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Currencies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
