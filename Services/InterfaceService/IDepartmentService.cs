using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterfaceService
{
    public  interface IDepartmentService
    {
        List<DepartmentDTO> GetDepartments();
        List<DepartmentEL> GetDepartmentsAndEmployees();
        List<DepartmentDTO> GetDepartment(int id);
        int Insert(DepartmentDTO departmentDTO);
        int Update(DepartmentDTO departmentDTO);
        int Delete(int id);
    }
}
