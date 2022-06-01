using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;

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
        public List<LocationDTO> GetLocations()
        {
            return locationService.GetLocations();
        }
        [HttpGet("GetLocation")]
        public List<LocationDTO> GetLocation(int id)
        {
            return locationService.GetLocation(id);
        }
        [HttpPost("Insert")]
        public int Insert(LocationDTO locationDTO)
        {
            return locationService.Insert(locationDTO);
        }
        [HttpPut("Update")]
        public int Update(LocationDTO locationDTO)
        {
            return locationService.Update(locationDTO);
        }
        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return locationService.Delete(Id);
        }
    }
}
