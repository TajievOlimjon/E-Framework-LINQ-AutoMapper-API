using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface IJobService
    {
        List<Job> GetJobs();
        Job GetJob(int Id);
        int Insert(Job  job);
        int Update(Job job);
        int Delete(int Id);
    }
}
