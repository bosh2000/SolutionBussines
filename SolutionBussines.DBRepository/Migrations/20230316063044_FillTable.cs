using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolutionBussines.DBRepository.Migrations
{
    /// <inheritdoc />
    public partial class FillTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Number", "ProviderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5896), "10-1", 1 },
                    { 2, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5909), "10-2", 1 },
                    { 3, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5912), "10-3", 2 },
                    { 4, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5914), "10-41", 1 },
                    { 5, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5915), "10-51", 3 },
                    { 6, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5916), "10-6", 5 },
                    { 7, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5917), "10-7", 6 },
                    { 8, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5919), "10-8", 6 },
                    { 9, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5920), "10-9", 6 },
                    { 10, new DateTime(2023, 3, 16, 16, 30, 44, 185, DateTimeKind.Local).AddTicks(5921), "10-11", 7 }
                });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Provider_21");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Provider_3");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Provider_4");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Provider_5");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Provider_6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Provider_7");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Provider_8");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Provider_9");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Provider_10");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Provider_11");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Provider_12");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Provider_13");

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 1, "Product_1", 1, 13m, "unit_1" },
                    { 2, "Product_11", 1, 13m, "unit_1" },
                    { 3, "Product_111", 2, 13m, "unit_1" },
                    { 4, "Product_12", 2, 13m, "unit_1" },
                    { 5, "Product_122", 2, 13m, "unit_1" },
                    { 6, "Product_13", 4, 13m, "unit_1" },
                    { 7, "Product_133", 4, 13m, "unit_1" },
                    { 8, "Product_14", 5, 13m, "unit_1" },
                    { 9, "Product_144", 5, 13m, "unit_1" },
                    { 10, "Product_15", 6, 13m, "unit_1" },
                    { 11, "Product_155", 6, 13m, "unit_1" },
                    { 12, "Product_16", 7, 13m, "unit_1" },
                    { 13, "Product_166", 7, 13m, "unit_1" },
                    { 14, "Product_17", 8, 13m, "unit_1" },
                    { 15, "Product_177", 8, 13m, "unit_1" },
                    { 16, "Product_18", 9, 13m, "unit_1" },
                    { 17, "Product_188", 9, 13m, "unit_1" },
                    { 18, "Product_19", 9, 13m, "unit_1" },
                    { 19, "Product_199", 10, 13m, "unit_1" },
                    { 20, "Product_10", 10, 13m, "unit_1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Provider_1");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Provider_1");
        }
    }
}
