using AutoMapper;
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
    public  class DepartmentService:IDepartmentService
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public DepartmentService(DataContext dataContext,IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        

        

        public List<DepartmentDTO> GetDepartments()
        {
            var list = (
                        from d in dataContext.Departments
                        select new DepartmentDTO()
                        {
                            Name=d.Name,
                            LocationId=d.LocationId,
                        }
                
                ).ToList();
            return list;
        }

        public List<DepartmentEL> GetDepartmentsAndEmployees()
        {
            var list = (
                        from d in dataContext.Departments
                        join e in dataContext.Employees on d.Id equals e.DepartmentId
                        join l in dataContext.Locations on d.LocationId equals l.Id
                        select new DepartmentEL()
                        {
                            EmployeeId = e.Id,
                            FullName = string.Concat(e.FirstName, " ", e.LastName),
                            Email = e.Email,
                            PhoneNumber = e.PhoneNumber,
                            HireDate = e.HireDate,
                            Salary = e.Salary,
                            DepartmentId = d.Id,
                            DepartmentName = d.Name,
                            LocationId = l.Id,
                            StreetAddress = l.StreetAddress,
                            PostalCode = l.PostalCode,
                            City = l.City,
                            StateProvince = l.StateProvince


                        }

                ).ToList();
            return list;
        }
        
        public List<DepartmentDTO> GetDepartment(int id)
        {
           
            var deparment = (from d in dataContext.Departments
                             where d.Id == id
                             select new DepartmentDTO()
                             {
                                 Id = d.Id,
                                 Name = d.Name,
                                 LocationId = d.LocationId
                             }

                             ).ToList();
            return  deparment;
        }

        public int Insert(DepartmentDTO departmentDTO)
        {
            var newDepartment = mapper.Map<Department>(departmentDTO);
            dataContext.Departments.Add(newDepartment);
            var save = dataContext.SaveChanges();
            return save;
        }

        public int Update(DepartmentDTO departmentDTO)
        {
            var newDepartment = dataContext.Departments.Find(departmentDTO.Id);
            newDepartment.Name = departmentDTO.Name;
            newDepartment.LocationId = departmentDTO.LocationId;
            var save = dataContext.SaveChanges();
            return save;
        }
        public int Delete(int id)
        {
            var delete = dataContext.Departments.Find(id);
            var d = dataContext.Departments.Remove(delete);
            var save = dataContext.SaveChanges();
            return save;
        }
    }
}
