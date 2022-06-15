using Domain.Entities;
using Domain.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeesInList();
        List<EmployeeEntrieDTO> GetEmployees();
        List<EmployeeDTO> GetEmployeeByJoin();
        List<EmployeeEntrieDTO> GetEmployee(int id);
        string Insert(EmployeeEntrieDTO employee);
        string Update(EmployeeEntrieDTO employee);
        string Delete(int id);

        List<EmployeeEntrieDTO> GetAllFullNames();


    }
}
