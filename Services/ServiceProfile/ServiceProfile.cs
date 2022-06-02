using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceProfile
{
    public class ServiceProfile:Profile
    {
        public ServiceProfile()
        {
            CreateMap<EmployeeDT, Employee>();
            CreateMap<DepartmentDTO, Department>();
            CreateMap<LocationDTO,Location>();
            CreateMap<CountrieDTO,Countrie>();

        }
    }
}
