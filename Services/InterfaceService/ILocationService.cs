using Domain.Entities;
using Domain.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface ILocationService
    {
        List<LocationEntrieDTO> GetLocations();
        List<LocationEntrieDTO> GetLocation(int id);
        int Insert(LocationEntrieDTO locationDTO);
        int Update(LocationEntrieDTO locationDTO);
        int Delete(int Id);
    }
}
