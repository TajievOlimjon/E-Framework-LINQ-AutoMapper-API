using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface ILocationService
    {
        List<LocationDTO> GetLocations();
        List<LocationDTO> GetLocation(int id);
        int Insert(LocationDTO locationDTO);
        int Update(LocationDTO locationDTO);
        int Delete(int Id);
    }
}
