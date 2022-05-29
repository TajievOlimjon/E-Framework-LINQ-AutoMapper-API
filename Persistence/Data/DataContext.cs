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


        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Dependent> Dependents { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<Countrie> Countries { get; set; }
        DbSet<Location> Locations { get; set; }

       


    }
}
