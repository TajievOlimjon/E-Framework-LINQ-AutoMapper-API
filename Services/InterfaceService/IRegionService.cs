using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface IRegionService
    {
        List<Region> GetRegions();
        Region GetRegionById(int Id);
        int Insert(Region region);
        int Update(Region region);
        int Delete(int Id);
    }
}
