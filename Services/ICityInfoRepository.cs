using CityInfo.API.Entities;
using CityInfo.API.Models;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        Task<(IEnumerable<City>, PaginationMetadata)> GetCitiesAsync(string? name, 
            string? searchQuery, int pageNumber, int pageSize);
        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);
        Task<bool> CityExistsAsync(int cityId);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestForCityAsync(int cityId);
        Task<PointOfInterest> GetPointsOfInterestForCityAsync(int cityId,
            int pointOfInterestId);
        Task<bool> AddPointOfInterestForCityAsync(int cityId,
            PointOfInterest pointOfInterest);
        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync();
    }
}
