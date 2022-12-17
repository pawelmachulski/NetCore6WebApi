using NetCore6WebApi.Models;

namespace NetCore6WebApi
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>(){
                new CityDto(){Id = 1, Name = "New York", Description = "empty" },
                new CityDto(){Id = 2, Name = "Warszawa", Description = "stolica Polski"}
            };
        }
    }
}
