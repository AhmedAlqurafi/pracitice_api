namespace Practice_MagicVilla.Models.Dto
{

    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
             new VillaDTO{Id = 1, Name = "Villa 1", Occupancy = 2, Sqft = 200},
                new VillaDTO{Id = 2, Name = "Villa 2", Occupancy = 3, Sqft = 400},
                new VillaDTO{Id = 3, Name = "Villa 3", Occupancy = 4, Sqft = 600}
        };
    }
}