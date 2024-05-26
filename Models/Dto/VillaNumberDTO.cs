using System.ComponentModel.DataAnnotations;

namespace Practice_MagicVilla.Models.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; } = "";
    }
}