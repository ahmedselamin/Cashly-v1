using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cashly.Server.Migrations
{
    /// <inheritdoc />
    public partial class UsersAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses");

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

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Expenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                columns: new[] { "UserId", "Id" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "UserId", "Amount", "CategoryId", "Date", "Title" },
                values: new object[,]
                {
                    { 1, 1, 5600m, 1, new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6962), "Salary" },
                    { 2, 1, 200m, 1, new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6971), "gift" },
                    { 3, 1, 50.76m, 2, new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6981), "Lunch" },
                    { 4, 1, 1200m, 2, new DateTime(2024, 7, 12, 8, 29, 20, 71, DateTimeKind.Local).AddTicks(6987), "rent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumns: new[] { "Id", "UserId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Expenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryId", "Date", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 5600m, 1, new DateTime(2024, 7, 12, 8, 19, 5, 767, DateTimeKind.Local).AddTicks(2938), "Salary", 0 },
                    { 2, 200m, 1, new DateTime(2024, 7, 12, 8, 19, 5, 767, DateTimeKind.Local).AddTicks(2942), "gift", 0 },
                    { 3, 50.76m, 2, new DateTime(2024, 7, 12, 8, 19, 5, 767, DateTimeKind.Local).AddTicks(2946), "Lunch", 0 },
                    { 4, 1200m, 2, new DateTime(2024, 7, 12, 8, 19, 5, 767, DateTimeKind.Local).AddTicks(2949), "rent", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");
        }
    }
}
