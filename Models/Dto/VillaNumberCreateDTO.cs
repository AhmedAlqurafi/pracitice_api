using System.ComponentModel.DataAnnotations;

namespace Practice_MagicVilla.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; } = "";
    }
}