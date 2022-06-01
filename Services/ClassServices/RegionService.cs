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
    public class RegionService:IRegionService
    {
        private readonly DataContext dataContext;

        public RegionService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int Id)
        {
            var delete = dataContext.Regions.Find(Id);
            var d=dataContext.Regions.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public Region GetRegionById(int Id)
        {
            var d = dataContext.Regions.Find(Id);
            return d;
        }

        public List<Region> GetRegions()
        {
            var list = dataContext.Regions.ToList();
            return list;
        }

        public int Insert(Region region)
        {
            dataContext.Regions.Add(region);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(Region region)
        {
            var newRegion = dataContext.Regions.Find(region.Id);
            newRegion.RegionName = region.RegionName;
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
