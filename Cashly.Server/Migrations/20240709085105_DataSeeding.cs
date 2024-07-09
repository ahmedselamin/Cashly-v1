using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cashly.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Income" },
                    { 2, "Expenditure" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryId", "Date", "Title" },
                values: new object[,]
                {
                    { 1, 5600m, 1, new DateTime(2024, 7, 9, 10, 51, 4, 741, DateTimeKind.Local).AddTicks(6181), "Salary" },
                    { 2, 200m, 1, new DateTime(2024, 7, 9, 10, 51, 4, 741, DateTimeKind.Local).AddTicks(6199), "gift" },
                    { 3, 50.76m, 2, new DateTime(2024, 7, 9, 10, 51, 4, 741, DateTimeKind.Local).AddTicks(6203), "Lunch" },
                    { 4, 1200m, 2, new DateTime(2024, 7, 9, 10, 51, 4, 741, DateTimeKind.Local).AddTicks(6205), "rent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
