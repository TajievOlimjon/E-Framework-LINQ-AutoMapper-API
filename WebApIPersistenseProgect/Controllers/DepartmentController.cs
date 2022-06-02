using Domain.Entities;
using Domain.EntitiesDTO;
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

        [HttpGet("GetDepartmentsAndEmployees")]
        public List<DepartmentDTO> GetDepartmentsAndEmployees()
        {
            return departmentService.GetDepartmentsAndEmployees();
        }

        [HttpGet("GetDepartments")]
        public List<DepartmentEntrieDTO> GetDepartments()
        {
            return departmentService.GetDepartments();
        }
       
        [HttpGet("GetDepartment")]
        public List<DepartmentEntrieDTO> GetDepartment(int id)
        {
            return departmentService.GetDepartments(id);
        }
        
        [HttpPost("Insert")]
        public int Insert(DepartmentEntrieDTO department)
        {
            return departmentService.Insert(department);
        }
        [HttpPut("Update")]
        public int Update(DepartmentEntrieDTO department)
        {
            return departmentService.Update(department);
        }
        [HttpDelete("Delete")]
        public int Delete(int id)
        {
            return departmentService.Delete(id);
        }

        
    }
}
