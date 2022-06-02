using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDTO;
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
        private readonly IMapper mapper;

        public CountrieService(DataContext dataContext,IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public int Delete(int id)
        {
            var delete = dataContext.Countries.Find(id);
            var d = dataContext.Countries.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public List<CountrieEntrieDTO> GetCountrie(int id)
        {
            var list=(from c in dataContext.Countries
                      select new CountrieEntrieDTO()
                      {
                          Id = id,
                          Name = c.Name,
                          RegionId=c.RegionId
                      }).ToList();
            return list;
        }

        public List<CountrieEntrieDTO> GetCountries()
        {
            var list = (
                        from c in dataContext.Countries
                        select new CountrieEntrieDTO
                        {
                            Id = c.Id,
                            Name=c.Name,
                            RegionId=c.RegionId
                        }


                        ).ToList();
            return list;
        }

        public int Insert(CountrieEntrieDTO countrie)
        {
            var newCountrie = mapper.Map<Countrie>(countrie);
            dataContext.Countries.Add(newCountrie);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(CountrieEntrieDTO countrie)
        {
            var newcountrie = dataContext.Countries.Find(countrie.Id);
            newcountrie.Name = countrie.Name;
            newcountrie.RegionId = countrie.RegionId;
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
