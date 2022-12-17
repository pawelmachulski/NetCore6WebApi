using Microsoft.AspNetCore.Mvc;
using NetCore6WebApi.Models;

namespace NetCore6WebApi.Controllers
{
    [ApiController]
    [Route("api/city/{cityId}/citystreets")]
    public class CityStreetController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityStreetDto>> GetCityStreets(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.Streets);
        }

        [HttpGet("{cityStreetId}")]
        public ActionResult<CityStreetDto> GetCityStreet(int cityId, int cityStreetId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var cityStreet = city.Streets.FirstOrDefault(x => x.Id == cityStreetId);
            if (cityStreet == null)
            {
                return NotFound();
            }

            return Ok(cityStreet);
        }
    }
}
