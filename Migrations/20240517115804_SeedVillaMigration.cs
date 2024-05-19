using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice_MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Private Pool, Ocean View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A spacious suite with luxurious amenities and a stunning ocean view.", "https://example.com/luxury-suite.jpg", "Luxury Suite", 4, 450.0, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Balcony, King Size Bed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A deluxe room featuring a king size bed and a private balcony.", "https://example.com/deluxe-room.jpg", "Deluxe Room", 2, 300.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Kitchenette, Two Queen Beds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perfect for families, this room includes a kitchenette and two queen beds.", "https://example.com/family-room.jpg", "Family Room", 5, 350.0, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Free WiFi, Queen Bed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A standard room with all the essentials for a comfortable stay.", "https://example.com/standard-room.jpg", "Standard Room", 2, 200.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Office Area, Complimentary Breakfast", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An executive suite featuring an office area and complimentary breakfast.", "https://example.com/executive-suite.jpg", "Executive Suite", 3, 400.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Jacuzzi, Romantic Decor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A romantic suite perfect for honeymooners, complete with a jacuzzi.", "https://example.com/honeymoon-suite.jpg", "Honeymoon Suite", 2, 500.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Private Elevator, Panoramic View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The presidential suite offers the ultimate in luxury with a private elevator and panoramic views.", "https://example.com/presidential-suite.jpg", "Presidential Suite", 4, 1000.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Living Area, Sofa Bed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A junior suite with a separate living area and a sofa bed.", "https://example.com/junior-suite.jpg", "Junior Suite", 3, 320.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Single Bed, Free Coffee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy single room with a comfortable single bed and free coffee.", "https://example.com/single-room.jpg", "Single Room", 1, 150.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Two Double Beds, Free Parking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A room with two double beds, ideal for friends traveling together.", "https://example.com/double-room.jpg", "Double Room", 2, 220.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
