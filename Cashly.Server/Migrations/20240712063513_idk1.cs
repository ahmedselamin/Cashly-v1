using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cashly.Server.Migrations
{
    /// <inheritdoc />
    public partial class idk1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 1, 5600m, 1, new DateTime(2024, 7, 12, 8, 35, 12, 116, DateTimeKind.Local).AddTicks(6856), "Salary", 1 },
                    { 2, 200m, 1, new DateTime(2024, 7, 12, 8, 35, 12, 116, DateTimeKind.Local).AddTicks(6863), "gift", 1 },
                    { 3, 50.76m, 2, new DateTime(2024, 7, 12, 8, 35, 12, 116, DateTimeKind.Local).AddTicks(6868), "Lunch", 1 },
                    { 4, 1200m, 2, new DateTime(2024, 7, 12, 8, 35, 12, 116, DateTimeKind.Local).AddTicks(6873), "rent", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { 1, 1, 5600m, 1, new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2656), "Salary" },
                    { 2, 1, 200m, 1, new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2665), "gift" },
                    { 3, 1, 50.76m, 2, new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2674), "Lunch" },
                    { 4, 1, 1200m, 2, new DateTime(2024, 7, 12, 8, 32, 56, 275, DateTimeKind.Local).AddTicks(2680), "rent" }
                });
        }
    }
}
