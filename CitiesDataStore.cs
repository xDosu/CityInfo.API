using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Tandil",
                    Description = "La mejor ciudad del mundo."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Azul",
                    Description = "Cerca de Tandil."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "General Piran",
                    Description = "Donde vive Guillermo Del Pino."
                }
            };
        }
    }
}
