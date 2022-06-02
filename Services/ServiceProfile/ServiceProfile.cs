using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDTO;
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
            CreateMap<EmployeeEntrieDTO, Employee>();
            CreateMap<DepartmentEntrieDTO, Department>();
            CreateMap<LocationEntrieDTO,Location>();
            CreateMap<CountrieEntrieDTO,Countrie>();
            

        }
    }
}
