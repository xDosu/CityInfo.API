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
                    Description = "La mejor ciudad del mundo.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "La Piedra Movediza",
                            Description = "Una piedra gigante"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Centinela",
                            Description = "Otra piedra gigante"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Azul",
                    Description = "Cerca de Tandil.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Municipio de Azul",
                            Description = "Donde labura el intendente."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "General Piran",
                    Description = "MDQ Team.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Campo Del Pino",
                            Description = "Donde se hacen los mejores chacinados."
                        }
                    }
                }
            };
        }
    }
}
