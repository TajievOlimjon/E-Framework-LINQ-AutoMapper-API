using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;
using Domain.EntitiesDTO;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService )
        {
            this.employeeService = employeeService;
        }

        [HttpGet("GetEmployeesInList")]
        public List<Employee> GetEmployeesInList()
        {
            return employeeService.GetEmployeesInList();
        }

        [HttpGet("GetEmployeeByJoin")]
        public List<EmployeeDTO> GetEmployeeByJoin()
        {
            return employeeService.GetEmployeeByJoin();
        }

        [HttpGet("GetEmployees")]
        public List<EmployeeEntrieDTO> GetEmployees()
        {
            return employeeService.GetEmployees();
        }

        [HttpGet("GetEmployee")]
        public List<EmployeeEntrieDTO> GetEmployee(int id)
        {
            return employeeService.GetEmployee(id);
        }

        [HttpGet("GetAllFullNames")]
        public List<EmployeeEntrieDTO> GetAllFullNames()
        {
            return employeeService.GetAllFullNames();
        }

        [HttpPost("Insert")]
        public string Insert(EmployeeEntrieDTO employee)
        {
            return employeeService.Insert(employee);
        }

        [HttpPut("Update")]
        public string Update(EmployeeEntrieDTO employee)
        {
            return employeeService.Update(employee);
        }

        [HttpDelete("Delete")]
        public string Delete(int id)
        {
            return employeeService.Delete(id);
        }


    }
}
