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
    public  class LocationService:ILocationService
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public LocationService(DataContext dataContext,IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public int Delete(int Id)
        {
            var delete = dataContext.Locations.Find(Id);
            var d = dataContext.Locations.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;

        }

        public List<LocationEntrieDTO> GetLocation(int id)
        {
            var list = (from l in dataContext.Locations
                        where l.Id==id
                        select new LocationEntrieDTO()
                        { Id=l.Id,
                          StreetAddress=l.StreetAddress,        
                          PostalCode=l.PostalCode,
                          City=l.City,
                          StateProvince=l.StateProvince,
                          CountrieId=l.CountrieId

                        }).ToList();
            return list;
        }

        public List<LocationEntrieDTO> GetLocations()
        {
            var list=(
                from l in dataContext.Locations
                join c in dataContext.Countries on l.CountrieId equals c.Id
                select new LocationEntrieDTO()
                {
                    Id = l.Id,
                    StreetAddress=l.StreetAddress,
                    PostalCode=l.PostalCode,
                    City=l.City,
                    StateProvince=l.StateProvince,
                    CountrieId=l.CountrieId

                }
                ).ToList();
            return list;
        }

        public int Insert(LocationEntrieDTO location)
        {
            var Newlocation = mapper.Map<Location>(location);
            dataContext.Locations.Add(Newlocation);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(LocationEntrieDTO location)
        {
            var newLocation = dataContext.Locations.Find(location.Id);
            newLocation.StreetAddress = location.StreetAddress;
            newLocation.PostalCode = location.PostalCode;
            newLocation.City = location.City;
            newLocation.StateProvince = location.StateProvince;
            newLocation.CountrieId = location.CountrieId;

            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
