using System.ComponentModel.DataAnnotations;

namespace Practice_MagicVilla.Models.Dto
{
    public class VillaCreateDTO
    {
        [Required]
        public required string Name { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }

    }
}
