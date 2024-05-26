using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice_MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class VillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 5, 44, 24, 698, DateTimeKind.Local).AddTicks(9361));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 15, 0, 27, 230, DateTimeKind.Local).AddTicks(4341));
        }
    }
}
