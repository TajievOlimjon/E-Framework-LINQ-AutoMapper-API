using Domain.Entities;
using Persistence.Data;
using Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClassServices
{
    public class CountrieService: ICountrieService 
    {
        private readonly DataContext dataContext;

        public CountrieService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int id)
        {
            var delete = dataContext.Countries.Find(id);
            var d = dataContext.Countries.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public List<CountrieDTO> GetCountrie(int id)
        {
            var list=(from c in dataContext.Countries
                      select new CountrieDTO()
                      {
                          Id = id,
                          Name = c.Name,
                          RegionId=c.RegionId
                      }).ToList();
            return list;
        }

        public List<CountrieDTO> GetCountries()
        {
            var list = (
                        from c in dataContext.Countries
                        select new CountrieDTO
                        {
                            Id = c.Id,
                            Name=c.Name,
                            RegionId=c.RegionId
                        }


                        ).ToList();
            return list;
        }

        public int Insert(CountrieDTO countrie)
        {
            Countrie newcountrie = new Countrie()
            {
                
                Name = countrie.Name,
                RegionId = countrie.RegionId

            };
            dataContext.Countries.Add(newcountrie);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(CountrieDTO countrie)
        {
            var newcountrie = dataContext.Countries.Find(countrie.Id);
            newcountrie.Name = countrie.Name;
            newcountrie.RegionId = countrie.RegionId;
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
