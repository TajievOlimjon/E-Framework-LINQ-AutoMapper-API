using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService regionService;

        public RegionController(IRegionService regionService)
        {
            this.regionService = regionService;
        }

        [HttpGet("GetRegions")]
        public   List<Region> GetRegions()
        {
            return regionService.GetRegions();
        }
        [HttpGet("GetRegionById")]
        public Region GetRegionById(int Id)
        {
            return regionService.GetRegionById(Id);
        }

        [HttpPost("Insert")]
        public  int Insert(Region region)
        {
            return regionService.Insert(region);
        }
        [HttpPut("Update")]
        public  int Update(Region region)
        {
           return regionService.Update(region);
        }

        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return regionService.Delete(Id);
        }
    }
}
