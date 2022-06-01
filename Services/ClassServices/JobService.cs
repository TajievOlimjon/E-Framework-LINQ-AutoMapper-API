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
    public  class JobService:IJobService
    {
        private readonly DataContext dataContext;

        public JobService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public int Delete(int Id)
        {
            var delete = dataContext.Jobs.Find(Id);
            dataContext.Jobs.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }

        public Job GetJob(int Id)
        {
            var d = dataContext.Jobs.Find(Id);
            return d;
        }

        public List<Job> GetJobs()
        {
            var list = dataContext.Jobs.ToList();
            return list;
        }

        public int Insert(Job job)
        {
            dataContext.Jobs.Add(job);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(Job job)
        {
            var newJobs = dataContext.Jobs.Find(job.Id);
            newJobs.JobTitle = job.JobTitle;
            newJobs.MinSalary = job.MinSalary;
            newJobs.MaxSalary = job.MaxSalary;
            var save = dataContext.SaveChanges();
            return save;

        }
    }
}
