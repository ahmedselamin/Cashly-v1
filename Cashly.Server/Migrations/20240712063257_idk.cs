using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cashly.Server.Migrations
{
    /// <inheritdoc />
    public partial class idk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 3, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 4, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2680));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 3, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 4, 1 },
                column: "Date",
                value: new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6987));
        }
    }
}
