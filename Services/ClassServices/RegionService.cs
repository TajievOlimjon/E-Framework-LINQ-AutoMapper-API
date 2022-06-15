using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
            if (delete == null) return 0;
            dataContext.Regions.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;

            //var d=dataContext.Regions.First(r=>r.Id==Id);
            //dataContext.Entry(d).State = EntityState.Deleted;
            //return dataContext.SaveChanges();

        }

        public Region GetRegionById(int Id)
        {
             var d = dataContext.Regions.FirstOrDefault(p => p.Id == Id);
            //var d = dataContext.Regions.SingleOrDefault(r => r.Id == Id);
            if (d == null) return new Region();
            return d;
        }

        public List<Region> GetRegions()
        {
            var list = dataContext.Regions.ToList();
            return list;
        }

        public int Insert(Region region)
        {
            //dataContext.Entry(region).State = EntityState.Added;
            //return dataContext.SaveChanges();
            dataContext.Regions.Add(region);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(Region region)
        {
            var newRegion = dataContext.Regions.Find(region.Id);
            if (newRegion == null) return 0;
            newRegion.RegionName = region.RegionName;
            return dataContext.SaveChanges();
            



            //dataContext.Regions.Attach(region);
            //dataContext.Entry(region).State = EntityState.Modified;
            //return dataContext.SaveChanges();
        }
    }
}
