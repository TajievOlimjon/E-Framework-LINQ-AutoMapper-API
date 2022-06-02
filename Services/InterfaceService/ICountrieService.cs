using Domain.Entities;
using Domain.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface ICountrieService
    {
        List<CountrieEntrieDTO> GetCountries();
        List<CountrieEntrieDTO> GetCountrie(int id);
        int Insert(CountrieEntrieDTO countrie);
        int Update(CountrieEntrieDTO countrie);
        int Delete(int id);

    }
}
