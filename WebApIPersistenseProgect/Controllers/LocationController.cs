using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;
using Domain.EntitiesDTO;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpGet("GetLocations")]
        public List<LocationEntrieDTO> GetLocations()
        {
            return locationService.GetLocations();
        }
        [HttpGet("GetLocation")]
        public List<LocationEntrieDTO> GetLocation(int id)
        {
            return locationService.GetLocation(id);
        }
        [HttpPost("Insert")]
        public int Insert(LocationEntrieDTO location)
        {
            return locationService.Insert(location);
        }
        [HttpPut("Update")]
        public int Update(LocationEntrieDTO location)
        {
            return locationService.Update(location);
        }
        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return locationService.Delete(Id);
        }
    }
}
