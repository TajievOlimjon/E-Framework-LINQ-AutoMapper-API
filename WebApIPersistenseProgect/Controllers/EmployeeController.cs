using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;
using Services.ClassServices;
using Domain.Entities;

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
        public List<EmployeeDT> GetEmployees()
        {
            return employeeService.GetEmployees();
        }

        [HttpGet("GetEmployee")]
        public List<EmployeeDT> GetEmployee(int id)
        {
            return employeeService.GetEmployee(id);
        }


        [HttpPost("Insert")]
        public string Insert(EmployeeDT employeedt)
        {
            return employeeService.Insert(employeedt);
        }

        [HttpPut("Update")]
        public string Update(EmployeeDT employeedt)
        {
            return employeeService.Update(employeedt);
        }

        [HttpDelete("Delete")]
        public string Delete(int id)
        {
            return employeeService.Delete(id);
        }


    }
}
