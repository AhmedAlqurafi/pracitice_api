using Microsoft.EntityFrameworkCore;
using Practice_MagicVilla.Models;

namespace Practice_MagicVilla.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(new Villa()
            {
                Id = 1,
                Name = "Luxury Suite",
                Occupancy = 4,
                Sqft = 1200,
                ImageUrl = "https://example.com/luxury-suite.jpg",
                Amenity = "Private Pool, Ocean View",
                Details = "A spacious suite with luxurious amenities and a stunning ocean view.",
                CreatedDate = DateTime.Now,
                Rate = 450.00
            },
            new Villa()
            {
                Id = 2,
                Name = "Deluxe Room",
                Occupancy = 2,
                Sqft = 800,
                ImageUrl = "https://example.com/deluxe-room.jpg",
                Amenity = "Balcony, King Size Bed",
                Details = "A deluxe room featuring a king size bed and a private balcony.",
                CreatedDate = DateTime.Now,
                Rate = 300.00
            }, new Villa()
            {
                Id = 3,
                Name = "Family Room",
                Occupancy = 5,
                Sqft = 1500,
                ImageUrl = "https://example.com/family-room.jpg",
                Amenity = "Kitchenette, Two Queen Beds",
                Details = "Perfect for families, this room includes a kitchenette and two queen beds.",
                CreatedDate = DateTime.Now,
                Rate = 350.00
            },
    new Villa()
    {
        Id = 4,
        Name = "Standard Room",
        Occupancy = 2,
        Sqft = 600,
        ImageUrl = "https://example.com/standard-room.jpg",
        Amenity = "Free WiFi, Queen Bed",
        CreatedDate = DateTime.Now,
        Details = "A standard room with all the essentials for a comfortable stay.",
        Rate = 200.00
    },
    new Villa()
    {
        Id = 5,
        Name = "Executive Suite",
        Occupancy = 3,
        Sqft = 1100,
        ImageUrl = "https://example.com/executive-suite.jpg",
        Amenity = "Office Area, Complimentary Breakfast",
        Details = "An executive suite featuring an office area and complimentary breakfast.",
        CreatedDate = DateTime.Now,
        Rate = 400.00
    },
    new Villa()
    {
        Id = 6,
        Name = "Honeymoon Suite",
        Occupancy = 2,
        Sqft = 1000,
        ImageUrl = "https://example.com/honeymoon-suite.jpg",
        Amenity = "Jacuzzi, Romantic Decor",
        Details = "A romantic suite perfect for honeymooners, complete with a jacuzzi.",
        CreatedDate = DateTime.Now,
        Rate = 500.00
    },
    new Villa()
    {
        Id = 7,
        Name = "Presidential Suite",
        Occupancy = 4,
        Sqft = 2000,
        ImageUrl = "https://example.com/presidential-suite.jpg",
        Amenity = "Private Elevator, Panoramic View",
        Details = "The presidential suite offers the ultimate in luxury with a private elevator and panoramic views.",
        CreatedDate = DateTime.Now,
        Rate = 1000.00
    },
    new Villa()
    {
        Id = 8,
        Name = "Junior Suite",
        Occupancy = 3,
        Sqft = 900,
        ImageUrl = "https://example.com/junior-suite.jpg",
        Amenity = "Living Area, Sofa Bed",
        Details = "A junior suite with a separate living area and a sofa bed.",
        CreatedDate = DateTime.Now,
        Rate = 320.00
    },
    new Villa()
    {
        Id = 9,
        Name = "Single Room",
        Occupancy = 1,
        Sqft = 400,
        ImageUrl = "https://example.com/single-room.jpg",
        Amenity = "Single Bed, Free Coffee",
        Details = "A cozy single room with a comfortable single bed and free coffee.",
        CreatedDate = DateTime.Now,
        Rate = 150.00
    },
    new Villa()
    {
        Id = 10,
        Name = "Double Room",
        Occupancy = 2,
        Sqft = 700,
        ImageUrl = "https://example.com/double-room.jpg",
        Amenity = "Two Double Beds, Free Parking",
        Details = "A room with two double beds, ideal for friends traveling together.",
        Rate = 220.00,
        CreatedDate = DateTime.Now,
    });
        }
    }
}
