using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}


       public   DbSet<Employee> Employees { get; set; }
       public  DbSet<Department> Departments { get; set; }
       public  DbSet<Dependent> Dependents { get; set; }
       public  DbSet<Job> Jobs { get; set; }
       public  DbSet<Region> Regions { get; set; }
       public  DbSet<Countrie> Countries { get; set; }
       public  DbSet<Location> Locations { get; set; }

       


    }
}
