using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("Tandil")
                {
                    Id = 1,
                    Description = "La mejor ciudad del mundo."
                },
                new City("Azul")
                {
                    Id = 2,
                    Description = "Cerca de Tandil."
                },
                new City("General Piran")
                {
                    Id = 3,
                    Description = "MDQ Team."
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("La Piedra Movediza")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Una piedra gigante."
                },
                new PointOfInterest("Centinela")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "Otra piedra gigante."
                },
                new PointOfInterest("Municipio de Azul")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Donde labura el intendente."
                },
                new PointOfInterest("Campo Del Pino")
                {
                    Id = 4,
                    CityId = 3,
                    Description = "Donde se hacen los mejores chacinados."
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
