using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountrieController : ControllerBase
    {
        private readonly ICountrieService countrieService;

        public CountrieController(ICountrieService countrieService)
        {
            this.countrieService = countrieService;
        }

        [HttpGet("GetCountries")]
       public  List<CountrieDTO> GetCountries()
        {
            return countrieService.GetCountries();
        }
        [HttpGet("GetCountrie")]
        public List<CountrieDTO> GetCountrie(int id)
        {
            return countrieService.GetCountrie(id);
        }
        [HttpPost("Insert")]
        public int Insert(CountrieDTO countrie)
        {
            return countrieService.Insert(countrie);
        }
        [HttpPut("Update")]
        public int Update(CountrieDTO countrie)
        {
            return countrieService.Update(countrie);
        }
        [HttpDelete("Delete")]
        public int Delete(int id)
        {
            return countrieService.Delete(id);
        }
    }
}
