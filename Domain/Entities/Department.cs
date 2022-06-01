using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Department
    {   [Key]
        [Column("Department_Id")]
        public int  Id { get; set; }

        [Column("Department_Name")]
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Column("Location_Name")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public  List<Employee>? Employees { get; set; }

    }


    public class DepartmentEL
    {
        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int LocationId { get; set; }
        public string? StreetAddress { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? StateProvince { get; set; }

    }
    public class DepartmentDTO
    {
     
        public int Id { get; set; }
        public string? Name { get; set; }
        public int LocationId { get; set; }


    }


}
