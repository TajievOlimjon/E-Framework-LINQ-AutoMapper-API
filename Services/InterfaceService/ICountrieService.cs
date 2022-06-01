using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface ICountrieService
    {
        List<CountrieDTO> GetCountries();
        List<CountrieDTO> GetCountrie(int id);
        int Insert(CountrieDTO countrie);
        int Update(CountrieDTO countrie);
        int Delete(int id);

    }
}
