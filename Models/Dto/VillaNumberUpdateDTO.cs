using System.ComponentModel.DataAnnotations;

namespace Practice_MagicVilla.Models.Dto
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; } = "";
    }
}