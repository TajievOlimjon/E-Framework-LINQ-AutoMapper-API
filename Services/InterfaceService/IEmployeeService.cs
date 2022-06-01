using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface IEmployeeService
    {   
        List<Employee> GetEmployeesInList();
        List<EmployeeDT> GetEmployees();
        List<EmployeeDTO> GetEmployeeByJoin();
        List<EmployeeDT> GetEmployee(int id);
        string  Insert(EmployeeDT employeedt);
        string  Update(EmployeeDT employeedt);
        string  Delete(int id);
    }
}
