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
    public  class LocationService:ILocationService
    {
        private readonly DataContext dataContext;

        public LocationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int Id)
        {
            var delete = dataContext.Locations.Find(Id);
            var d = dataContext.Locations.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;

        }

        public List<LocationDTO> GetLocation(int id)
        {
            var list = (from l in dataContext.Locations
                        select new LocationDTO()
                        { Id=l.Id,
                          StreetAddress=l.StreetAddress,        
                          PostalCode=l.PostalCode,
                          City=l.City,
                          StateProvince=l.StateProvince,
                          CountrieId=l.CountrieId

                        }).ToList();
            return list;
        }

        public List<LocationDTO> GetLocations()
        {
            var list=(
                from l in dataContext.Locations
                join c in dataContext.Countries on l.CountrieId equals c.Id
                select new LocationDTO()
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

        public int Insert(LocationDTO locationDTO)
        {
            Location location = new Location()
            {
                StreetAddress = locationDTO.StreetAddress,
                PostalCode = locationDTO.PostalCode,
                City = locationDTO.City,
                StateProvince = locationDTO.StateProvince,
                CountrieId = locationDTO.CountrieId
            };
            
            
            dataContext.Locations.Add(location);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(LocationDTO locationDTO)
        {
            var newLocation = dataContext.Locations.Find(locationDTO.Id);
            newLocation.StreetAddress = locationDTO.StreetAddress;
            newLocation.PostalCode = locationDTO.PostalCode;
            newLocation.City = locationDTO.City;
            newLocation.StateProvince = locationDTO.StateProvince;
            newLocation.CountrieId = locationDTO.CountrieId;

            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
