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
    public  class EmployeeService:IEmployeeService
    {
        private readonly DataContext dataContext;
        private IMapper mapper;
        public EmployeeService(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;

        }



        public List<EmployeeDTO> GetEmployeeByJoin()
        {
            var list = (from e in dataContext.Employees
                        join d in dataContext.Departments on e.DepartmentId equals d.Id
                        select new EmployeeDTO()
                        {
                            EmployeeId = e.Id,
                            FullName = string.Concat(e.FirstName, " ", e.LastName),
                            Email = e.Email,
                            PhoneNumber = e.PhoneNumber,
                            HireDate = e.HireDate,
                            Salary = e.Salary,
                            DepartmentId = d.Id,
                            DepartmentName = d.Name


                        }).ToList();
            return list;
        }

        public List<EmployeeDT> GetEmployees()
        {
            var list = (
                    from e in dataContext.Employees
                    select new EmployeeDT()
                    {
                        Id = e.Id,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Email = e.Email,
                        PhoneNumber = e.PhoneNumber,
                        HireDate = e.HireDate,
                        Salary = e.Salary,
                        JobId = e.JobId,
                        DepartmentId = e.DepartmentId
                    }).ToList();
            return list;
        }

        public string Insert(EmployeeDT employeedt)
        {
            var newEmployee = mapper.Map<Employee>(employeedt);
            dataContext.Employees.Add(newEmployee);
            var save = dataContext.SaveChanges();
            if (!save.Equals(null)) return " Saved in Database!!!!";
            return " Not Saved in DataBase!";
             
        }

        public string Update(EmployeeDT employeedt)
        {
            var newEmployee = dataContext.Employees.Find(employeedt.Id);
            newEmployee.FirstName = employeedt.FirstName;
            newEmployee.LastName = employeedt.LastName;
            newEmployee.Email = employeedt.Email;
            newEmployee.PhoneNumber = employeedt.PhoneNumber;
            newEmployee.HireDate = employeedt.HireDate;
            newEmployee.Salary = employeedt.Salary;
            newEmployee.JobId = employeedt.JobId;
            newEmployee.DepartmentId = employeedt.DepartmentId;
            var save = dataContext.SaveChanges();
            if (!save.Equals(null)) return " Updated in Database!!!!";
            return " Not Updated in DataBase!";

        }

        public string Delete(int id)
        {
            var employee = dataContext.Employees.Find(id);
            var d = dataContext.Employees.Remove(employee);
            var save = dataContext.SaveChanges();
            if (!employee.Equals(null)) return " Deleted in Database!!!!";
            return " Not Deleted in DataBase!";

        }

        public List<EmployeeDT> GetEmployee(int id)
        {
            var list = (
                     from e in dataContext.Employees
                     where e.Id==id
                     select new EmployeeDT()
                     {
                         Id = e.Id,
                         FirstName = e.FirstName,
                         LastName = e.LastName,
                         Email = e.Email,
                         PhoneNumber = e.PhoneNumber,
                         HireDate = e.HireDate,
                         Salary = e.Salary,
                         JobId = e.JobId,
                         DepartmentId = e.DepartmentId

                     }).ToList();
            return list;
        }

        public List<Employee> GetEmployeesInList()
        {
            var list = dataContext.Employees.ToList();
            return list;
        }
    }
}
