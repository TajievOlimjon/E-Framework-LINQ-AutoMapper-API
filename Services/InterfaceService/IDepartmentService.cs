using Domain.Entities;
using Domain.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.InterfaceService
{
    public  interface IDepartmentService
    {
        List<DepartmentDTO> GetDepartmentsAndEmployees();
        List<DepartmentEntrieDTO> GetDepartments();
        List<DepartmentEntrieDTO> GetDepartments(int id);
        int Insert(DepartmentEntrieDTO departmentDTO);
        int Update(DepartmentEntrieDTO departmentDTO);
        int Delete(int id);
    }
}
