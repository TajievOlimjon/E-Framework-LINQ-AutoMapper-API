using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.InterfaceService;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        [HttpGet("GetDepartments")]
        public List<DepartmentDTO> GetDepartments()
        {
            return departmentService.GetDepartments();
        }
        [HttpGet("GetDepartmentsAndEmployees")]
        public List<DepartmentEL> GetDepartmentsAndEmployees()
        {
            return departmentService.GetDepartmentsAndEmployees();
        }
        [HttpGet("GetDepartment")]
        public List<DepartmentDTO> GetDepartment(int id)
        {
            return departmentService.GetDepartment(id);
        }
        
        [HttpPost("Insert")]
        public int Insert(DepartmentDTO departmentDTO)
        {
            return departmentService.Insert(departmentDTO);
        }
        [HttpPut("Update")]
        public int Update(DepartmentDTO departmentDTO)
        {
            return departmentService.Update(departmentDTO);
        }
        [HttpDelete("Delete")]
        public int Delete(int id)
        {
            return departmentService.Delete(id);
        }

        
    }
}
