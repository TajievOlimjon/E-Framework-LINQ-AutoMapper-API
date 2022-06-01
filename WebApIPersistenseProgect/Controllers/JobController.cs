using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService jobService;

        public JobController(IJobService jobService)
        {
            this.jobService = jobService;
        }

        [HttpGet("GetJobs")]
       public  List<Job> GetJobs()
        {
            return jobService.GetJobs();
        }
        [HttpGet("GetJob")]
        public  Job GetJob(int Id)
        {
            return jobService.GetJob(Id);
        }
        [HttpPost("Insert")]
        public  int Insert(Job job)
        {
            return jobService.Insert(job);
        }
        [HttpPut("Update")]
        public  int Update(Job job)
        {
          return  jobService.Update(job);
        }
        [HttpDelete("Delete")]
        public int Delete(int Id)
        {
            return jobService.Delete(Id);
        }
    }
}
